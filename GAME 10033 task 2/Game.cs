// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using static MohawkGame2D.Game;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //tiltle and size of game
            Window.SetTitle("sunset interactive");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //background color (sky)
            Window.ClearBackground(new Color(0, 0, 255 - 255 * Input.GetMouseY() / 400));

            
        


            //sun that follows the mouse
            Draw.FillColor = Color.Yellow;
            Draw.LineSize = 4;
            Draw.LineColor = Color.Yellow;
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 50);



            //the front hill the sun sets behind
            Draw.FillColor = Color.Green;
            Draw.LineSize = 4;
            Draw.LineColor = Color.Green;
            Draw.Circle(new Vector2(200, 650), 400);


        }


    }

}
