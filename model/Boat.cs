using System;

namespace lm222qb_workshop2
{
    /// <summary>
    /// A class representing a boat at the yacht club.
    /// </summary>
    class Boat
    {
        //The Boat type.
        private string type;

        //The length of the Boat.
        private int length;
        
        //Getters and setters
        public string Type {
            get{
               return type;
            }

            set{
                type = value;
            }
        }

        public int Length {
            get{
               return length;
            }

            set{
                length = value;
            }
        }

         /// <summary>
        /// Creates an instance of the Boat class.
        /// </summary>
        public Boat(string type, int length){
            Type = type;
            Length = length; 
        }
    }
}
