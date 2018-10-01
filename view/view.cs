using System;
using System.Collections.Generic;
using System.Linq;


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
            Console.WriteLine("\nMain Menu\n1. Add Member\n2. Delete Member\n3. Update Member (Change member info, Add boat, Delete boat, Update boat) \n4. View Member\n5. List Members\n");
            Console.WriteLine("Choose action (1-5):");
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

        public List<String> updateMemberView(){
            Console.WriteLine("\n-----UPDATE MEMBER-----\n");
            Console.WriteLine("Enter ID of the member to be updated:");
            string memberIdInput = Console.ReadLine();

            Console.WriteLine("\n1. Change member info\n2. Add boat\n3. Delete boat\n4. Update boat\n");
            Console.WriteLine("Choose action (1-4):");
            string actionInput = Console.ReadLine();

            List<String> memberIDandActionInput = new List<String>();

            memberIDandActionInput.Add(memberIdInput);
            memberIDandActionInput.Add(actionInput);
            
            return memberIDandActionInput;
        }

        public List<String> updateMemberInfoView(){
            
            Console.WriteLine("\n-----UPDATE MEMBER INFO-----\n");
            Console.WriteLine("Enter new name of member:");
            string nameInput = Console.ReadLine();

            Console.WriteLine("\n-----UPDATE MEMBER INFO-----\n");
            Console.WriteLine("Enter new personal number of member:");

            string numberInput = Console.ReadLine();

            List<String> nameAndNumberInput = new  List<String>();

            nameAndNumberInput.Add(nameInput);
            nameAndNumberInput.Add(numberInput);

            return nameAndNumberInput;
        }

        public List<String> addBoatView(){
            
            Console.WriteLine("\n-----ADD BOAT-----\n");
            Console.WriteLine("Enter boat type (Sailboat, Motorsailer, kayak/Canoe, Other):");
            string boatTypeInput = Console.ReadLine();

            Console.WriteLine("\n-----ADD BOAT-----\n");
            Console.WriteLine("Enter boat length in meters:");

            string boatLengthInput = Console.ReadLine();

            List<String> boatTypeAndLengthInput = new  List<String>();

            boatTypeAndLengthInput.Add(boatTypeInput);
            boatTypeAndLengthInput.Add(boatLengthInput);

            return boatTypeAndLengthInput;
        }


        public string deleteBoatView(){
            
            Console.WriteLine("\n-----DELETE BOAT-----\n");
            Console.WriteLine("Enter the type of the boat to be deleted:");
            string boatTypeInput = Console.ReadLine();

            return boatTypeInput;
        }

         public List<String> updateBoatView(){
            
            Console.WriteLine("\n-----UPDATE BOAT-----\n");
            Console.WriteLine("Enter new boat type (Sailboat, Motorsailer, kayak/Canoe, Other):");
            string boatTypeInput = Console.ReadLine();

            Console.WriteLine("\n-----UPDATE BOAT-----\n");
            Console.WriteLine("Enter new boat length in meters:");

            string boatLengthInput = Console.ReadLine();

            List<String> boatTypeAndLengthInput = new  List<String>();

            boatTypeAndLengthInput.Add(boatTypeInput);
            boatTypeAndLengthInput.Add(boatLengthInput);

            return boatTypeAndLengthInput;
        }


        public string listMembersView(){
            Console.WriteLine("\n-----LIST MEMBERS-----\n");
            Console.WriteLine("\n1. Compact list (name, member id and number of boats)\n2. Verbose list (name, personal number, member id and boats with boat information)\n");
            Console.WriteLine("Choose type of List (1-2):");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public void errorMessage (string errorString){

        }

    }
}