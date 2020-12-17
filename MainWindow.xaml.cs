using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Hangman
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game;

        /// <summary>
        /// This is the MainWindow method which gets called at the start of the application.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
            game.UpdateHangman();

            DataContext = game;

        }

        /// <summary>
        /// This method is used to create a new game. Also to restart an already existing game.
        /// </summary>
        private void NewGame ()
        {
            game = new Game();
        }

        /**
         * Your tasks are...
         *
         *  1) Build the graphical user interface (GUI) for the game
         *  2) Implement the logic to react to guesses (letters)
         *  3) Implement the logic to mask (hide) the word to guess while representing the number of characters
         *  4) Implement the logic to display correctly guessed characters in the masked word
         *  5) Show the remaining lives using the provided images lives_5.png to lives_0.png
         *  6) Implement "win" and "game over" notifications for the user and trigger them accordingly
         *  7) Be proud, have fun and play your own hangman game!
         */
    }

    /// <summary>
    /// This class represents a game instance. Every game is its own instance of this class.
    /// </summary>
    class Game
    {
        /// <summary>
        /// This is the word the player should guess.
        /// </summary>
        public readonly string _Word;
        // Initially the player has 5 lives.
        // Every wrong guess decreases the number of remaining lives.
        private int _lives = 5;

        public string ImagePath { get; private set; }


        /// <summary>
        /// This method updates the image path (ImagePath property) of the hangman.
        /// </summary>
        public void UpdateHangman ()
        {
            switch (_lives)
            {
                case 5:
                    ImagePath = "live_5.png";
                    break;
                case 4:
                    ImagePath = "live_4.png";
                    break;
                case 3:
                    ImagePath = "live_3.png";
                    break;
                case 2:
                    ImagePath = "live_2.png";
                    break;
                default:
                    ImagePath = "live_1.png";
                    break;
            }
        }

        /// <summary>
        /// This constructor assignes the readonly to a random word from the WordLibrary class.
        /// </summary>
        public Game ()
        {
            _Word = WordLibrary.GetWord();
        }
    }
}
