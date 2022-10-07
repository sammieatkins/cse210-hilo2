using System;

namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A card assigned a random number between 1-13.
        /// 
        /// The responsibility of Die is to keep track of its current value.
        /// </summary> 

        public class Card
        {
            public int value;

            // 2) Create the class constructor. Use the following method comment.
            /// <summary>
            /// Constructs a new instance of Card by calling the Draw() function.
            /// </summary>
            public Card()
            {
                Draw();
            }

            /// <summary>
            /// Generates a new random value for the card.
            /// </summary>
            public void Draw()
            {
                Random rnd = new Random();
                value = rnd.Next(1, 14); 
            }
        }       
}