using System;

namespace lm222qb_workshop2
{
    /// <summary>
    /// A class representing a boat at the yacht club.
    /// </summary>
    class Boat
    {
        //The Boat type.
        private string _type;

        //The length of the Boat.
        private int _length;

        public string Type {
            get{
               return _type;
            }

            set{
                _type = value;
            }
        }

        public int Length {
            get{
               return _length;
            }

            set{
                _length = value;
            }
        }

         /// <summary>
        /// Creates an instance of the Boat class.
        /// </summary>
        public Boat(string type, int length){
            Type = type;
            Length = length; 
        }

        /// <summary>
        /// Creates a copy of the Boat class.
        /// </summary>
        /// <returns>
        /// A copy of the Boat.
        /// </returns>
        public Boat Copy(){
            return (Boat)MemberwiseClone();        
        }

        /// <summary>
        /// Creates a string containing information about the boat.
        /// </summary>
        /// <returns>
        /// a string containing information about the boat.
        /// </returns>
        public override string ToString(){
            string memberInfoString = $"Type: {this.Type}\nLength: {this.Length}";

            return memberInfoString;
        }

    }
}
