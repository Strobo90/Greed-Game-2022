using System;
namespace cse210_04.Game.Casting;
    // create the falling objects
    public class ObjectFactory
    {
        
        private Point position;
        private string image;
        private int score;
        private int multiplier;
        private Point fallingspeed;
        private int r;
        private int g;
        private int b;
        private int FONT_SIZE = 15;
        Color color = new Color(0,0,0);
        private string gemShape = ("*");
//     @" __
// /| |\
// \| |/
// \/").ToString();
        private string rockShape = ("O");
// @"_
// /-\
// \_/").ToString(); //makes the rock's shape


           
        private string multiplierGemShape = ("M");
        //     @"    /\
        // /__\
        // \__/
        //     \/").ToString(); // the multiplier gem shape

        public void defineobject(int type, Point Position, Cast cast)
        {
            position = Position;
            switch(type)
            {
            case 1:
                // Basic rock 
                image = rockShape;
                r = 228;
                g = 166;
                b = 24;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 3);
                score = -250;
                multiplier = -1;
 
            break;
            
             case 2:
             // tiny rock 
                image = rockShape;

                r = 208;
                g = 146;
                b = 4;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 2);
                score = -100;
                multiplier = -1;
            break;

             case 3 :
             // little rock 
                image = rockShape;

                r = 228;
                g = 166;
                b = 24;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 5);
                score = -500;
                multiplier = -1;
            break;

             case 4:
                // big rock 
                image = rockShape;
                r = 228;
                g = 166;
                b = 24;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 5);
                score = -1000;
                multiplier = -1;
 
            break;
             case 5:
                // biggest rock 
                image = rockShape;
                r = 255;
                g = 255;
                b = 150;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 5);
                score = -10000;
                multiplier = -1;
 
            break;
            
            case 6 :
                // gem basic
                image = gemShape;

                r = 68;
                g = 197;
                b = 236;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 2);
                score = 100;
                multiplier = 0;
                
            break;
            case 7 :
                // gem mid
                image = gemShape;

                r = 200;
                g = 0;
                b = 236;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 4);
                score = 500;
                multiplier = 0;
                
            break;
            case 8 :
                // gem high
                image = gemShape;

                r = 200;
                g = 0;
                b = 0;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 5);
                score = 1000;
                multiplier = 0;
                
            break;
             case 9 :
                // gem low
                image = gemShape;

                r = 68;
                g = 197;
                b = 236;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 1);
                score = 50;
                multiplier = 0;
                
            break;
            
            case 10 :
             // multiplier Gem
                image = multiplierGemShape;

                r = 100;
                g = 255;
                b = 100;
                color = new Color(r, g, b);
                fallingspeed = new Point(0, 5);
                score = 100;
                multiplier = 1;
            break;
            }
            
            createobject(cast);
        }
        private void createobject(Cast cast)
        {

                FallingObject fallingObject = new FallingObject(); // <-- INSTANCE OF FALLING OBJECT
                fallingObject.SetText(image); // <-- DEPENDING ON THE OBJECT
                fallingObject.SetFontSize(FONT_SIZE);
                fallingObject.SetColor(color);
                fallingObject.SetPosition(position);
                fallingObject.setMultiplier(multiplier);
                fallingObject.setPointValue(score);
                fallingObject.SetVelocity(fallingspeed);
                // cannot access the instance of cast that director created
                cast.AddActor("fallingObjects", fallingObject);
        }
    }       