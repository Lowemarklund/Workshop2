using System;
using System.Collections.Generic;
using System.Linq;

//mainview 

//listview
//add, delete, update member, view

namespace lm222qb_workshop2
{
    /// <summary>
    /// A class representing a the userinterface of the CRUD system.
    /// </summary>
    class View
    {
        public View(){

        }
        //The main menu of the user interface.
        public string mainView(){
            Console.WriteLine("\nMain Menu\n1. Add Member\n2. Delete Member\n3. Update Member\n4. View Member\n5. List Members\n");
            Console.WriteLine("Choose action (1-5)");
            string userInput = Console.ReadLine();
            return userInput;
        }

        
        public List<String> addMemberView(){
            
            Console.WriteLine("\n-----ADD MEMBER-----\n");
            Console.WriteLine("Enter name of member:");
            string nameInput = Console.ReadLine();

            Console.WriteLine("\n-----ADD MEMBER-----\n");
            Console.WriteLine("Enter personal number of member:");

            string numberInput = Console.ReadLine();

            List<String> nameAndNumberInput = new  List<String>();

            nameAndNumberInput.Add(nameInput);
            nameAndNumberInput.Add(numberInput);

            return nameAndNumberInput;
        }

        public string deleteMemberView(){
            Console.WriteLine("\n-----DELETE MEMBER-----\n");
            Console.WriteLine("Enter ID of the member to be deleted:");
            string userInput = Console.ReadLine();
            return userInput;
        }

    }
}