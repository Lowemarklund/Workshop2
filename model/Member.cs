using System;
using System.Collections.Generic;
using System.Linq;

namespace lm222qb_workshop2
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
        private string _number;

        //The boats belonging to the member.
        private List<Boat> _boats = new List<Boat>();

        public string Name {
            get{
               return _name;
            }

            set{
                _name = value;
            }
        }

        public int Id {
            get{
               return _id;
            }

            set{
                _id = value;
            }
        }

        public string Number {
            get{
               return _number;
            }

            set{
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
        public Member(string name, string number, int id){
            Name = name;
            Number = number;
            Id = id; 
        }

        /// <summary>
        /// Creates a string containing the member's information.
        /// </summary>
        public override string ToString(){
            string memberInfoString = $"\nName: {this.Name}\nId: {this.Id}\nPersonal number: {this.Number}";

            return memberInfoString;
        }

    }
}
