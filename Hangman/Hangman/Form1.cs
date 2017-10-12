using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        //list of words and list of possible words left
        public string[] Words, PossibleWords;
        //the chosen word, bad and good guess lists, unchosen letters, guess format
        public string TheWord, BadGuesses, GoodGuesses, PossibleLetters, GuessesSoFar;
        //number of guesses
        public int GuessCount;
        //required to reset so you can't guess before word is picked
        bool GameStarted = false;

        public Form1()
        {
            InitializeComponent();
            PlayButton.Hide();
            numericUpDown1.Hide();
            GuessCountLabel.Hide();
            WinningGif.Hide();
            GuessButton.Hide();
        }
        //open screen
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
            PlayButton.Show();
            numericUpDown1.Show();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            //if game has started
            if(GameStarted && GuessCount > 0)
            {
                try
                {
                    //pick beginning letter based on popularity, words left
                    Random r = new Random();
                    int index = 0;
                    string guess = "";

                    //guess first letters of remaining words after first hit
                    if(GoodGuesses.Length == 1)
                    {
                        index = r.Next(0, PossibleWords.Length);
                        guess = PossibleWords[index][PossibleWords[index].Length-1].ToString();
                    }//if we are one guess away
                    else if(TheWord.Length - GoodGuesses.Length == 1)
                    {
                        index = label2.Text.IndexOf("_");
                        guess = PossibleWords[0][index].ToString();
                    }else
                    {
                        //guess based on letters found in possible words
                        index = label2.Text.IndexOf("_");
                        guess = PossibleWords[r.Next(0,PossibleWords.Length)][index].ToString();

                        //if letter has been guessed - guess based on popular
                        if (GuessesSoFar.Contains(guess))
                        {
                            //just guess on the popular side of random letters
                            {
                                index = r.Next(0, PossibleLetters.Length / 3);
                                guess = PossibleLetters[index].ToString();
                            }
                        }
                    }
                    
                    PossibleLetters = PossibleLetters.Replace(guess, "");

                    //letter is a good guess
                    if (TheWord.Contains(guess))
                    {
                        
                        //change word string
                        string temp = "";
                        int i = 0;
                        foreach (char c in TheWord)
                        {
                            string letter = c.ToString();
                            if (letter.Equals(guess)) //add it and sort words based on position of guess
                            {
                                temp += guess;
                                GoodGuesses += guess;
                                PossibleWords = (from p in PossibleWords
                                                 where p[i] == TheWord[i]
                                                 select p).ToArray();
                            }
                            else
                            {
                                temp += GuessesSoFar[i];
                            }
                            i++;
                        }
                        label2.Text = temp;
                        GuessesSoFar = temp;

                        

                    }//letter is a bad guess
                    else
                    {
                        BadGuesses += guess;
                        label1.Text = BadGuesses;
                        GuessCount--;
                        GuessCountLabel.Text = GuessCount.ToString();
                        //remove words from list containing bad guessed letter
                        PossibleWords = (from p in PossibleWords
                                         where !p.Contains(guess)
                                         select p).ToArray();
                    }

                    possible.Text = PossibleLetters;
                    possiblewordcount.Text = PossibleWords.Length.ToString();

                    if (GuessCount == 0)
                    {
                        WinningGif.Show();
                    }
                    if(label2.Text == TheWord)
                    {
                        GuessButton.Hide();
                    }
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }

        }

        //pick a word button based on number
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 19)
            {
                label2.Text = "No words of this length";
            }
            else
            {
                //reset
                ResetGame();

                PossibleWords = (from w in Words
                                 where w.Length == numericUpDown1.Value
                                 select w).ToArray(); // O(logn) search for words with certain length

                Random r = new Random();
                TheWord = PossibleWords[r.Next(0, PossibleWords.Length)];

                for(int i = 0; i < TheWord.Length; i++)
                {
                    GuessesSoFar += "_";
                }
                //set text for guesses _ _ _
                label2.Text = GuessesSoFar;

                foreach(var item in TheWord)
                {
                    test.Text += item;
                }
                
            }
        }

        private void ObtainWordList()
        {
            string ListPath = Path.Combine(
                          Path.GetDirectoryName(
                          Assembly.GetExecutingAssembly().Location),
                          "words.txt");

            Words = File.ReadAllLines(ListPath);

        }

        //on form start
        private void Form1_Load(object sender, EventArgs e)
        {
            ObtainWordList();
            GoodGuesses = "";
            BadGuesses = "";
        }

        //when new word is picked
        public void ResetGame()
        {
            GuessCount = 9;
            GameStarted = true;
            GuessCountLabel.Text = GuessCount.ToString();
            GuessCountLabel.Show();
            WinningGif.Hide();
            GuessButton.Show();
            GoodGuesses = "";
            BadGuesses = "";
            PossibleLetters = "etainoshrdlucmfwygpbvkqjxz"; //most popular letters based on https://en.oxforddictionaries.com/explore/which-letters-are-used-most
            GuessesSoFar = "";
            label1.Text = "";
            label2.Text = "";
            test.Text = "";
            TheWord = "";
        }
    }
}
