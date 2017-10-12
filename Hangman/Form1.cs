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

        public SortedSet<String> PossibleWordSet, TempSet, WordSet;

        //the chosen word, bad and good guess lists, unchosen letters, guess format
        public string TheWord, BadGuesses, GoodGuesses, PossibleLetters, GuessesSoFar, Guess;
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
            WrongButton.Hide();
            RightButton.Hide();
            IndexInfo.Hide();
            IndexButton.Hide();
        }

        private void IndexButton_Click(object sender, EventArgs e)
        {
            //index will be user
            //change word string
            //IndexButton.Hide();
            //IndexInfo.Hide();
            //WrongButton.Show();
            //RightButton.Show();

            GuessText.Text = Guess;
            string temp = IndexInfo.Text;
            IndexInfo.Hide();
            IndexButton.Hide();
            TipText.Hide();
            List<int> indexList = temp.Split(',').Select(int.Parse).ToList();
            

            foreach (int i in indexList )
            {
               
                StringBuilder sb = new StringBuilder(TheWord);
                sb[i] = char.Parse(Guess);
                TheWord = sb.ToString();

                //might need to do a temp set = to possibleWordSet and run the query on that
                PossibleWordSet = new SortedSet<string>(from p in PossibleWordSet
                                                        where p[i] == TheWord[i] //the guess
                                                        select p);
            }
            label2.Text = TheWord;
            GuessesSoFar += Guess;

            possible.Text = PossibleLetters;
            possiblewordcount.Text = PossibleWordSet.Count.ToString();



            //new guess
            var count = TheWord.Count(x => x == '_'); //count of _
            if(count == 1)
            {
                PossibleWordSet = new SortedSet<string>(from p in PossibleWordSet
                                                        where PossibleLetters.Contains(p[TheWord.IndexOf('_')])  //the guess
                                                        select p);
            }

            PossibleLetters = PossibleLetters.Replace(Guess, "");
            
            Guess = PossibleLetters[0].ToString();

            GuessText.Text = Guess;

            WrongButton.Show();
            RightButton.Show();
            IndexInfo.Clear();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            RightButton.Hide();
            WrongButton.Hide();
            MakeGuess(true);
            
        }

        private void WrongButton_Click(object sender, EventArgs e)
        {
            MakeGuess(false);
        }

        //open screen
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
            PlayButton.Show();
            numericUpDown1.Show();
            HowManyText.Text = "How Many Letters In The Word?";
        }

        private void MakeGuess(bool correct)
        {
            //if game has started
            if (GameStarted && GuessCount > 0)
            {
                try
                {

                    //letter is a good guess
                    if (correct)
                    {
                        IndexButton.Show();
                        IndexInfo.Show();
                        TipText.Show();
                        WrongButton.Hide();
                        RightButton.Hide();

                    }//letter is a bad guess
                    else
                    {

                        BadGuesses += Guess;
                        PossibleLetters = PossibleLetters.Replace(Guess, "");
                        Guess = PossibleLetters[0].ToString();
                        label2.Text = TheWord;
                        GuessText.Text = Guess;

                        
                        label1.Text = BadGuesses;
                        GuessCount--;
                        GuessCountLabel.Text = GuessCount.ToString();
                        //remove words from list containing bad guessed letter
                        PossibleWordSet = new SortedSet<string>(from p in PossibleWordSet
                                                                where !p.Contains(Guess)
                                                                select p);
                        possible.Text = PossibleLetters;
                        possiblewordcount.Text = PossibleWordSet.Count.ToString();
                    }

                    

                    if (GuessCount == 0)
                    {
                        WinningGif.Show();
                        RightButton.Hide();
                        WrongButton.Hide();
                        GuessText.Hide();
                    }

                    
                    

                    //if (label2.Text == TheWord)
                    //{
                    //    RightButton.Hide();
                    //    WrongButton.Hide();
                    //}
                }
                catch (Exception ex)
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

                PossibleWordSet = new SortedSet<string>(from w in Words
                                                        where w.Length == numericUpDown1.Value
                                                        select w);

                Random r = new Random();

                //TheWord = PossibleWords[r.Next(0, PossibleWords.Length)];

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    TheWord += "_";
                }
                //set text for guesses _ _ _
                label2.Text = TheWord;

                foreach (var item in TheWord)
                {
                    test.Text += item;
                }

                //initial guess on play
                //Guess = PossibleLetters[0].ToString();

                GuessText.Text = Guess;

                //PossibleLetters = PossibleLetters.Replace(Guess, "");

            }
        }

        private void ObtainWordList()
        {
            string ListPath = Path.Combine(
                          Path.GetDirectoryName(
                          Assembly.GetExecutingAssembly().Location),
                          "words.txt");

            Words = File.ReadAllLines(ListPath);
            WordSet = new SortedSet<string>(Words);

        }

        //on form start
        private void Form1_Load(object sender, EventArgs e)
        {
            ObtainWordList();
            GoodGuesses = "";
            BadGuesses = "";
            GuessText.Hide();
            WinningGif.Hide();
            TipText.Hide();
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
            GoodGuessesText.Hide();
            GuessCount = 9;
            GameStarted = true;
            GuessCountLabel.Text = GuessCount.ToString();
            GuessCountLabel.Show();
            WinningGif.Hide();
            RightButton.Show();
            WrongButton.Show();
            GuessText.Show();
            GoodGuesses = "";
            BadGuesses = "";
            PossibleLetters = "etainoshrdlucmfwygpbvkqjxz"; //most popular letters based on https://en.oxforddictionaries.com/explore/which-letters-are-used-most
            GuessesSoFar = "";
            label1.Text = "";
            label2.Text = "";
            test.Text = "";
            TheWord = "";
            Guess = PossibleLetters[0].ToString();
            label2.Text = Guess;
            IndexButton.Hide();
            IndexInfo.Hide();
            TipText.Hide();
        }
    }
}