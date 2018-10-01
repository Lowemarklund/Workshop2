using System;
using System.Collections.Generic;
using System.Linq;


namespace lm222qb_workshop2
{
    class User{
        
        public bool run(View view, MemberList memberList){

            string userInput = view.mainView();
            //User wants to add member
            if(userInput == "1"){
                addMember(view, memberList);
            }
            if(userInput == "2"){
                deleteMember(view, memberList);
            }

            if(userInput == "3"){
                updateMember(view, memberList);
            }

            if(userInput == "5"){
                listMembers(view, memberList);
            }

            return true;
        }

        public void addMember(View view, MemberList memberList){
            List<String> nameAndNumberinput = view.addMemberView();
            memberList.addMember(nameAndNumberinput[0], nameAndNumberinput[1]);
            Console.WriteLine("\nMember Added.");
        }

        public void deleteMember(View view, MemberList memberList){
            //Id of member to be deleted.
            string memberId = view.deleteMemberView();
            memberList.deleteMember(Int32.Parse(memberId));
            Console.WriteLine("\nMember Deleted.");
        }

        public void updateMember(View view, MemberList memberList){

            List<String> memberIdandActionInput = view.updateMemberView();
            int memberId = Int32.Parse(memberIdandActionInput[0]);
            string action = memberIdandActionInput[1];

            //Update Member info
            if(action == "1"){
                List<String> nameAndNumberinput = view.updateMemberInfoView();

                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                        member.Name = nameAndNumberinput[0];
                        member.Number = nameAndNumberinput[1];
                    }
                }
            }
            //Add boat
            if(action == "2"){
                List<String> boatTypeAndLengthInput = view.addBoatView();

                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                       member.addBoat(boatTypeAndLengthInput[0], Int32.Parse(boatTypeAndLengthInput[1]));
                    }
                }
            }
            //Delete boat
            if(action == "3"){
                String boatTypeInput = view.deleteBoatView();
                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                       member.deleteBoat(boatTypeInput);
                    }
                }
            }
            //Update boat
            if(action == "4"){
                List<String> boatTypeAndLengthInput = view.updateBoatView();
                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                       member.updateBoat(boatTypeAndLengthInput[0], Int32.Parse(boatTypeAndLengthInput[1]));
                    }
                }
            }

        }

        public void listMembers(View view, MemberList memberList){
            // string listTypeInput = view.listMembersView();
            foreach(Member member in memberList.getMembers()){
                Console.WriteLine(member.ToString());
            }
        }


        public User(){
           
        }

    }
}