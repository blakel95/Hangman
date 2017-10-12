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
        public string[] Words;

        public SortedSet<String> possibleWordSet, tempSet;

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
            HowManyText.Text = "How Many Letters In The Word?";
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            //if game has started
            if(GameStarted && GuessCount > 0)
            {
                try
                {
                    //guess first most common letter left
                    Random r = new Random();
                    int index = 0;
                    string guess = "";

                    guess = PossibleLetters[0].ToString();

                    ////if we are one guess away
                    //if(TheWord.Length - GoodGuesses.Length == 1)
                    //{
                    //    index = label2.Text.IndexOf("_");
                    //    guess = PossibleWords[0][index].ToString();
                    //}else
                    //{
                    //    //guess based on letters found in possible words
                    //    index = label2.Text.IndexOf("_");
                    //    guess = PossibleWords[r.Next(0,PossibleWords.Length)][index].ToString();

                    //if letter has been guessed - guess based on popular
                    //if (GuessesSoFar.Contains(guess))
                    //    {
                    //        //just guess on the popular side of random letters
                    //        {
                    //            guess = PossibleLetters[0].ToString();
                    //        }
                    //    }
                    
                    
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
                                //might need to do a temp set = to possibleWordSet and run the query on that
                                possibleWordSet = new SortedSet<string> (from p in possibleWordSet
                                                                         where p[i] == TheWord[i]
                                                                         select p);
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
                        possibleWordSet = new SortedSet<string>(from p in possibleWordSet
                                                                where !p.Contains(guess)
                                                                select p);
                    }

                    possible.Text = PossibleLetters;
                    possiblewordcount.Text = possibleWordSet.Count.ToString();

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

                //PossibleWords = (from w in Words
                //                 where w.Length == numericUpDown1.Value
                //                 select w).ToArray(); // O(logn) search for words with certain length

                possibleWordSet = new SortedSet<string>(from w in Words
                                                 where w.Length == numericUpDown1.Value
                                                 select w);

                Random r = new Random();

                //TheWord = PossibleWords[r.Next(0, PossibleWords.Length)];

                TheWord = "ben";

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
            TheWordText.Text = "The Word Being Guessed:";
            PossibleText.Text = "# of Possible Words Left:";
            LettersLeftText.Text = "Letters Left:";
            BadGuessesText.Text = "Bad Guesses:";
            GoodGuessesText.Text = "Good Guesses:";
            GuessesLeftText.Text = "Guesses Left:";
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
