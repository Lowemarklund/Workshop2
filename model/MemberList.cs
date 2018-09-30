using System;
using System.Collections.Generic;
using System.Linq;

namespace lm222qb_workshop2
{
    /// <summary>
    /// A class representing a list of members in the yacht club.
    /// </summary>
    class MemberList
    {
        private List<Member> _members = new List<Member>();

        public void addMember(string name, string number){
           
            int memberID; 
            //if there are no members in the list the ID will be 0.
            if(_members.Count == 0){
                memberID = 0;
            }else{
                memberID = _members[_members.Count - 1].Id-1;
            }

            Member newMember = new Member(name, number, memberID);
            _members.Add(newMember);
        }

        public void DeleteMember(){
            
        }

        public void updateMember(){
            
        }

        public void getMember(){
            
        }

        public List<Member> getMembers(){
            return _members;
        }

        public MemberList(){
            //members = file of members
        }

    }
}