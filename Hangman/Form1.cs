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
        //required to reset so you can't guess before word is pickedw
        bool GameStarted = false;

        public Form1()
        {
            InitializeComponent();
            PlayButton.Hide();
            numericUpDown1.Hide();
            GuessCountLabel.Hide();
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
                    //pick beginning letter at random
                    Random r = new Random();
                    int index = r.Next(0, PossibleLetters.Length);
                    string guess = PossibleLetters[index].ToString();
                    PossibleLetters.Remove(index);

                    //if letter has not been picked and IS in word
                    if (TheWord.Contains(guess) && !GoodGuesses.Contains(guess) && !BadGuesses.Contains(guess))
                    {
                        GoodGuesses += guess;
                        //change word string
                        string temp = "";
                        int i = 0;
                        foreach (char c in TheWord)
                        {
                            string letter = c.ToString();
                            if (letter.Equals(guess))
                            {
                                temp += guess;
                            }
                            else
                            {
                                temp += GuessesSoFar[i];
                            }
                            i++;
                        }
                        label2.Text = temp;
                        GuessesSoFar = temp;

                        PossibleWords = (from p in PossibleWords
                                         where p.Contains(guess)
                                         select p).ToArray();

                    }//if letter has not been picked and is NOT in word
                    else if (!BadGuesses.Contains(guess) && !GoodGuesses.Contains(guess))
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
                    else
                    {
                        //do nothing - guess again
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
            GoodGuesses = "";
            BadGuesses = "";
            PossibleLetters = "abcdefghijklmnopqrstuvwxyz";
            GuessesSoFar = "";
            label1.Text = "";
            label2.Text = "";
            test.Text = "";
            TheWord = "";
        }
    }
}
