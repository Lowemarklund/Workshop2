using System;
using System.Collections.Generic;
using System.Linq;


namespace lm222qb_workshop2
{
    /// <summary>
    /// A class representing the userinterface of the CRUD system.
    /// </summary>
    class View
    {
        public View(){

        }
        //The main menu of the user interface.
        public string mainView(){
            Console.WriteLine("\nMAIN MENU\n1. Add Member\n2. Delete Member\n3. Update Member (Change member info, Add boat, Delete boat, Update boat) \n4. View Member\n5. List Members\n6. Quit\n");
            Console.WriteLine("Choose action (1-6):");
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
            Console.WriteLine("Enter boat type (Sailboat, Motorsailer, Kayak, Canoe, Other):");
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
            Console.WriteLine("Enter the type of the boat to be deleted (Sailboat, Motorsailer, Kayak, Canoe, Other):");
            string boatTypeInput = Console.ReadLine();

            return boatTypeInput;
        }

         public List<String> updateBoatView(){
            
            Console.WriteLine("\n-----UPDATE BOAT-----\n");
            Console.WriteLine("Enter new boat type (Sailboat, Motorsailer, Kayak, Canoe, Other):");
            string boatTypeInput = Console.ReadLine();

            Console.WriteLine("\n-----UPDATE BOAT-----\n");
            Console.WriteLine("Enter new boat length in meters:");

            string boatLengthInput = Console.ReadLine();

            List<String> boatTypeAndLengthInput = new List<String>();

            boatTypeAndLengthInput.Add(boatTypeInput);
            boatTypeAndLengthInput.Add(boatLengthInput);

            return boatTypeAndLengthInput;
        }
        public string selectMemberView(){
            Console.WriteLine("\n-----VIEW MEMBER-----\n");
            Console.WriteLine("Enter ID of the member to be viewed:");
            string memberIdInput = Console.ReadLine();
            return memberIdInput;

        }
        public void viewMemberInfoView(MemberList memberList, int id){
            Console.WriteLine("\n-----VIEW MEMBER-----\n");
            Console.WriteLine("___________________");
            foreach(Member member in memberList.getMembers()){
                int i = 1;
                if(member.Id == id){
                    string memberInfoString = $"\nName: {member.Name}\nPersonal number: {member.Number}\nId: {member.Id}\n";
                    Console.WriteLine(memberInfoString);

                //Writes out each boats information
                foreach(Boat boat in member.getBoats()){
                    string boatInfoString = $"Boat #{i}\nType: {boat.Type}\nLength: {boat.Length}\n";
                    i++;
                    Console.WriteLine(boatInfoString);
                }
                }
                
            }
            Console.WriteLine("___________________");
        }


        public string listMembersView(){
            Console.WriteLine("\n-----LIST MEMBERS-----\n");
            Console.WriteLine("\n1. Compact list (name, member id and number of boats)\n2. Verbose list (name, personal number, member id and boats with boat information)\n");
            Console.WriteLine("Choose type of List (1-2):");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public void compactListView(MemberList memberList){
            Console.WriteLine("\n-----COMPACT MEMBER LIST-----\n");
            Console.WriteLine("___________________");
            foreach(Member member in memberList.getMembers()){
                string memberInfoString = $"\nName: {member.Name}\nId: {member.Id}\nNumber of boats: {member.getBoats().Count}\n";
                Console.WriteLine(memberInfoString);
                Console.WriteLine("___________________");
            }
        }

        public void verboseListView(MemberList memberList){
            Console.WriteLine("\n-----VERBOSE MEMBER LIST-----\n");
            Console.WriteLine("___________________");

            foreach(Member member in memberList.getMembers()){
                int i = 1;
                string memberInfoString = $"\nName: {member.Name}\nPersonal number: {member.Number}\nId: {member.Id}\n";
                Console.WriteLine(memberInfoString);

                //Writes out each boats information
                foreach(Boat boat in member.getBoats()){
                    string boatInfoString = $"Boat #{i}\nType: {boat.Type}\nLength: {boat.Length}\n";
                    i++;
                    Console.WriteLine(boatInfoString);
                }
                Console.WriteLine("___________________");
            }
        }

        public void errorMessage (int errorType){
            if(errorType == 1){
                Console.WriteLine("\nInvalid member ID.");
            }

            if(errorType == 2){
                Console.WriteLine("\nInvalid action.");
            }

            if(errorType == 3){
                Console.WriteLine("\nInvalid boat type.");
            }

            if(errorType == 4){
                Console.WriteLine("\nMember already has that type of boat (Members can only have one of each type of boat).");
            }

            if(errorType == 5){
                Console.WriteLine("\nMember doesn't own that type of boat.");
            }

             if(errorType == 6){
                Console.WriteLine("\nNo members have yet to be added.");
            }



        }

    }
}