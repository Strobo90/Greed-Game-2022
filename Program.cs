using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using cse210_04.Game.Casting;
using cse210_04.Game.Directing;
using cse210_04.Game.Services;


namespace cse210_04
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Greed";
        private static Color WHITE = new Color(255, 255, 255);
        
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the score tracker
            ScoreTracker scoretracker = new ScoreTracker();
            scoretracker.SetText("");
            scoretracker.SetFontSize(FONT_SIZE);
            scoretracker.SetColor(WHITE);
            scoretracker.SetPosition(new Point(CELL_SIZE,0));
            cast.AddActor("scoretracker", scoretracker);

            // create the score banner
            Actor scoreBanner = new Actor();
            scoreBanner.SetText("Score: 0");
            scoreBanner.SetFontSize(FONT_SIZE);
            scoreBanner.SetColor(WHITE);
            scoreBanner.SetPosition(new Point(CELL_SIZE,0));
            cast.AddActor("score banner", scoreBanner);

            // create the multiplier banner
            Actor multiplierBanner = new Actor();
            multiplierBanner.SetText("Multiplier: 1x");
            multiplierBanner.SetFontSize(FONT_SIZE);
            multiplierBanner.SetColor(WHITE);
            multiplierBanner.SetPosition(new Point(MAX_X - (15*CELL_SIZE), 0));
            cast.AddActor("multiplier banner", multiplierBanner);

            // create the minecart
            Actor minecart = new Actor();
            minecart.SetText("U"); // <-- SHAPE OF THE MAIN CHARACTER
            minecart.SetFontSize(FONT_SIZE);
            minecart.SetColor(WHITE);
            minecart.SetPosition(new Point(MAX_X / 2, MAX_Y-15));
            cast.AddActor("minecart", minecart); // <-- WHAT NAME ARE WE GIVING IT?

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}