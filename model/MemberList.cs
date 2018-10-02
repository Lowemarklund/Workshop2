using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

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
                memberID = _members[_members.Count - 1].Id+1;
            }

            Member newMember = new Member(name, number, memberID);
            _members.Add(newMember);
        }

        public void deleteMember(int id){
            _members.RemoveAt(id);
            updateMemberIDs();
        }

        public List<Member> getMembers(){
            List<Member> memberListCopy = new List<Member>();
            
            foreach(Member member in _members){
                memberListCopy.Add(member.Copy());
            }
            return memberListCopy;
        }

        public void updateMemberIDs (){
            for(int i = 0; i <_members.Count; i++){
                _members[i].Id = i;
            }
        }

        public void writeMemberListToFile(){
            string path = System.IO.Directory.GetCurrentDirectory();
            string json = JsonConvert.SerializeObject(_members);
            File.WriteAllText($@"{path}/members.txt", String.Empty);
            System.IO.File.WriteAllText($@"{path}/members.txt", json);
        }

        private List<Member> loadMemberListFromFile(){
            string path = System.IO.Directory.GetCurrentDirectory();
            
            //Error handling if file is empty.
            if(new FileInfo( $@"{path}/members.txt" ).Length == 0){
                Console.WriteLine("1weqasd");
                //returns empty list of members.
                return getMembers();
            }

            var jsonContents = System.IO.File.ReadAllText($@"{path}/members.txt");
            List<Member> memberList = JsonConvert.DeserializeObject<List<Member>>(jsonContents);
            return memberList;
        }

        public MemberList(){
           _members = loadMemberListFromFile();
        }

    }
}