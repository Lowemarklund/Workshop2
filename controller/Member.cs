using System;
using System.Collections.Generic;
using System.Linq;


namespace controller
{
    /// <summary>
    /// A class representing a member in the yacht club.
    /// </summary>
    class Member
    {
        //The Members name.
        private string _name;

        //The Members unique id.
        private int _id;

        //The Members personal number.
        private int _number;

        //private List<Boat> _boats = new List<Boat>();

        public string Name {
            get{
               return _name;
            }

            private set{
                _name = value;
            }
        }

        public int Id {
            get{
               return _id;
            }

            private set{
                _id = value;
            }
        }

        public int Number {
            get{
               return _number;
            }

            private set{
                _number = value;
            }
        }

        /// <summary>
        /// Creates an instance if the Member class.
        /// </summary>
        public Member(string name, int id, int number){
            Name = name;
            Id = id; 
            Number = number;
        }

        /// <summary>
        /// Creates a string containing the member's information.
        /// </summary>
        /// <returns>
        /// A string containing the member's information.
        /// </returns>
        public override string ToString(){
            string memberInfoString = $"{this.Name}\n{this.Id}\n{this.Number}\n";

            return memberInfoString;
        }

    }
}
