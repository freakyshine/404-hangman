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

        // This is the word the player should guess
        private readonly string _word;

        // Initially the player has 5 lives.
        // Every wrong guess decreases the number of remaining lives.
        private int _lives = 5;

        public MainWindow()
        {
            InitializeComponent();

            _word = WordLibrary.GetWord();
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
}
