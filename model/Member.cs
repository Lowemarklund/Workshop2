using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
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

        //The boats belonging to the member.
        private List<Boat> _boats = new List<Boat>();

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
        /// Returns a list a with the boats belonging to the member.
        /// </summary>
        public List<Boat> getBoats(){
            return _boats.Select(boat => (Boat) boat.Copy()).ToList();
        }

        /// <summary>
        /// Adds a boat to the list of boats belonging to the member.
        /// </summary>
        public void addBoat(BoatType type, string id, int length ){
            Boat newBoat = new Boat (type, id, length);
            _boats.Add(newBoat);
        }

        /// <summary>
        /// Creates an instance of the Member class.
        /// </summary>
        public Member(string name, int id, int number){
            Name = name;
            Id = id; 
            Number = number;
        }

        /// <summary>
        /// Creates a string containing the member's information.
        /// </summary>
        public override string ToString(){
            string memberInfoString = $"Name: {this.Name}\nId: {this.Id}\nPersonal number: {this.Number}\n";

            return memberInfoString;
        }

    }
}
