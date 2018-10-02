using System;
using System.Collections.Generic;
using System.Linq;


namespace lm222qb_workshop2
{
    class User{
        
         /// <summary>
        /// Starts the CRUD Application
        /// </summary>
        /// <returns>
        /// Boolean.
        /// </returns>
        public bool run(View view, MemberList memberList){

            string userInput = view.mainView();
            //Main menu input.
            if(userInput == "1"){
                addMember(view, memberList);
            }
            if(userInput == "2"){
                deleteMember(view, memberList);
            }

            if(userInput == "3"){
                updateMember(view, memberList);
            }

            if(userInput == "4"){
                viewMemberInfo(view, memberList);
            }

            if(userInput == "5"){
                listMembers(view, memberList);
            }
            //Keeps running until user chooses to quit and false is returned.
            if(userInput == "6"){
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds a member to the list.
        /// </summary>
        public void addMember(View view, MemberList memberList){
            List<String> nameAndNumberinput = view.addMemberView();
            memberList.addMember(nameAndNumberinput[0], nameAndNumberinput[1]);
            memberList.writeMemberListToFile();
        }

        /// <summary>
        /// Removes a member from the list.
        /// </summary>
        public void deleteMember(View view, MemberList memberList){
            string memberId = view.deleteMemberView();

            //Error handling
            if(checkID(memberList, Int32.Parse(memberId)) == false){
                view.errorMessage(1);
                return;
            }

            memberList.deleteMember(Int32.Parse(memberId));
            memberList.writeMemberListToFile();
        }

        /// <summary>
        /// Updates a members information.
        /// </summary>
        public void updateMember(View view, MemberList memberList){

            List<String> memberIdandActionInput = view.updateMemberView();
            int memberId = Int32.Parse(memberIdandActionInput[0]);
            string action = memberIdandActionInput[1];

            if(checkID(memberList, memberId) == false){
                view.errorMessage(1);
                return;
            }

            //Update Member info
            if(action == "1"){
                List<String> nameAndNumberinput = view.updateMemberInfoView();

                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                        member.updateMemberInfo(nameAndNumberinput[0], nameAndNumberinput[1]);
                    }
                }
            }
            //Add boat
            if(action == "2"){
                List<String> boatTypeAndLengthInput = view.addBoatView();
                //Error handling
                if(boatTypeAndLengthInput[0] != "Sailboat" && boatTypeAndLengthInput[0] != "Motorsailer" && boatTypeAndLengthInput[0] != "Kayak" && boatTypeAndLengthInput[0] != "Canoe" && boatTypeAndLengthInput[0] != "Other"){
                    view.errorMessage(3);
                    return;
                }


                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                        //Error handling
                       if(checkBoat(member, boatTypeAndLengthInput[0]) == true){
                           view.errorMessage(4);
                           return;
                       }
                       member.addBoat(boatTypeAndLengthInput[0], Int32.Parse(boatTypeAndLengthInput[1]));
                    }
                }
            }

            //Delete boat
            if(action == "3"){
                String boatTypeInput = view.deleteBoatView();
                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                        //Error handling
                        if(checkBoat(member, boatTypeInput) == false){
                            view.errorMessage(5);
                            return;
                        }

                        member.deleteBoat(boatTypeInput);
                        return;
                    }
                }
            }
            //Update boat
            if(action == "4"){
                List<String> boatTypeAndLengthInput = view.updateBoatView();
                foreach(Member member in memberList.getMembers()){
                    if(member.Id == memberId){
                        //Error handling
                        if(checkBoat(member, boatTypeAndLengthInput[0]) == false){
                            view.errorMessage(5);
                            return;
                        }
                       member.updateBoat(boatTypeAndLengthInput[0], Int32.Parse(boatTypeAndLengthInput[1]));
                    }
                }
            //Error handling
            }else if(action != "1" && action != "2" && action != "3" && action != "4") {
                view.errorMessage(2);
                return;
            }
            //Saves member list to file.
            memberList.writeMemberListToFile();
        }

         /// <summary>
        /// Gets a members info.
        /// </summary>
        public void viewMemberInfo(View view, MemberList memberList){
            int memberId = Int32.Parse(view.selectMemberView());
            //Error handling
            if(checkID(memberList, memberId) == false){
                view.errorMessage(1);
                return;
            }
            view.memberInfoView(memberList, memberId);
        }

         /// <summary>
        /// Lists members.
        /// </summary>
        public void listMembers(View view, MemberList memberList){
            string listTypeInput = view.listMembersView();
            if(memberList.getMembers().Count == 0){
                view.errorMessage(6);
                return;
            }

            if(listTypeInput == "1"){
                view.compactListView(memberList);
            }

            if(listTypeInput == "2"){
                view.verboseListView(memberList);

            //Error handling
            }else if(listTypeInput != "1" && listTypeInput != "2"){
                view.errorMessage(2);
                return;
            }
        }

         /// <summary>
        /// Checks if member ID exists in member list.
        /// </summary>
         /// <returns>
        /// Boolean.
        /// </returns>
        public bool checkID(MemberList memberList, int memberId){
            foreach(Member member in memberList.getMembers()){
                if(memberId == member.Id){
                    return true;
                } 
            }
            return false;
        }

        /// <summary>
        /// Checks if boat exists in members boat list.
        /// </summary>
         /// <returns>
        /// Boolean.
        /// </returns>
        public bool checkBoat(Member member, string boatType){
            foreach(Boat boat in member.getBoats()){
                if(boatType == boat.Type){
                    return true;
                }
            }
            return false;
        }
    }
}