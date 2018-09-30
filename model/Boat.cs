using System;

namespace lm222qb_workshop2
{
    /// <summary>
    /// A class representing a boat at the yacht club.
    /// </summary>
    class Boat
    {
        //The Boat type.
        private BoatType _type;

        //The length of the Boat.
        private int _length;

        //The Id of the boat.
        private string _id;

        public BoatType Type {
            get{
               return _type;
            }

            private set{
                _type = value;
            }
        }

        public int Length {
            get{
               return _length;
            }

            private set{
                _length = value;
            }
        }

        public string Id {
            get{
               return _id;
            }

            private set{
                _id = value;
            }
        }

         /// <summary>
        /// Creates an instance of the Boat class.
        /// </summary>
        public Boat(BoatType type, string id, int length){
            Type = type;
            Id = id;
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
            string memberInfoString = $"Type: {this.Type}\nLength: {this.Length}\nId: {this.Id}";

            return memberInfoString;
        }

    }
}
