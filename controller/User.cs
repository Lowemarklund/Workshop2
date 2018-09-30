using System;
using System.Collections.Generic;
using System.Linq;


namespace lm222qb_workshop2
{
    class User{
        
        public bool run(View view, MemberList memberList){

            string userInput = view.mainView();
            //User wants to add member
            if(userInput== "1"){
                addMember(view, memberList);
            }
            if(userInput== "2"){
                deleteMember(view, memberList);
            }
            if(userInput== "5"){
                listMembers(memberList);
            }

            else{
                Console.WriteLine("Not yet implemented");
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

        public void listMembers(MemberList memberList){
            foreach(Member member in memberList.getMembers()){
                Console.WriteLine(member.ToString());
            }
        }


        public User(){
           
        }

    }
}