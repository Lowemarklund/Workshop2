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
        public void addBoat(string type, int length ){
            Boat newBoat = new Boat (type, length);
            _boats.Add(newBoat);
        }

        /// <summary>
        /// Removes a boat from the list of boats belonging to the member.
        /// </summary>
        public void deleteBoat(string type){
          for(int i = 0; i < _boats.Count; i++){
              if(_boats[i].Type == type){
                  _boats.Remove(_boats[i]);
              }
          }
        }

        /// <summary>
        /// Updates a boat's length in the list of boats belonging to the member.
        /// </summary>
        public void updateBoat(string type, int length){
          for(int i = 0; i < _boats.Count; i++){
              if(_boats[i].Type == type){
                  _boats[i].Length = length;
              }
          }
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
            string memberInfoString = $"\nName: {this.Name}\nId: {this.Id}\nPersonal number: {this.Number}\nBoat: {this._boats[0].Type} \nBoat length: {this._boats[0].Length}";

            return memberInfoString;
        }

    }
}
