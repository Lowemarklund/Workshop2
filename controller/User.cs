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

            }else{
                Console.WriteLine("Not yet implemented");
            }

            return true;
        }

        public void addMember(View view, MemberList memberList){
            List<String> nameAndNumberinput = view.addMemberView();
            memberList.addMember(nameAndNumberinput[0], nameAndNumberinput[1]);
            foreach(Member member in memberList.getMembers()){
                Console.WriteLine(member.ToString());
            }
        }


        public User(){
           
        }

    }
}