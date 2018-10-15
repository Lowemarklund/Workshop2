using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Input;
using System.Reflection;

namespace lm222qb_workshop2
{
    /// <summary>
    /// A class representing a list of members in the yacht club.
    /// </summary>
    class MemberList
    {
        // The list of members
        private List<Member> members = new List<Member>();

        /// <summary>
        /// Adds a member to the list.
        /// </summary>
        public void addMember(string name, string number){
           
            int memberID; 
            //if there are no members in the list the ID will be 0.
            if(members.Count == 0){
                memberID = 0;
            }else{
                memberID = members[members.Count - 1].Id+1;
            }

            Member newMember = new Member(name, number, memberID);
            members.Add(newMember);
        }

        /// <summary>
        /// Removes a member from the list.
        /// </summary>
        public void deleteMember(int id){
            members.RemoveAt(id);
            updateMemberIDs();
        }

        /// <summary>
        /// Returns member from the list.
        /// </summary>
        /// <returns>
        /// A member from the list.
        /// </returns>
        public Member getMember(int memberId){
            return members[memberId];
        }

        /// <summary>
        /// Returns the list of members.
        /// </summary>
        /// <returns>
        /// The member list.
        /// </returns>
        public List<Member> getMembers(){
            return members;
        }

        /// <summary>
        /// Updates the IDs of the members in the list.
        /// </summary>
        public void updateMemberIDs (){
            for(int i = 0; i <members.Count; i++){
                members[i].Id = i;
            }
        }

        /// <summary>
        /// Saves the member list to file.
        /// </summary>
        public void writeMemberListToFile(){
            string json = JsonConvert.SerializeObject(members);
            File.WriteAllText($@"./members.txt", String.Empty);
            System.IO.File.WriteAllText($@"./members.txt", json);
        }

        /// <summary>
        /// Loads a member list from file.
        /// </summary>
        /// <returns>
        /// A member list.
        /// </returns>
        private List<Member> loadMemberListFromFile(){
            string path = Directory.GetCurrentDirectory();
            //Error handling if file is empty.
            if(new FileInfo( $@"{path}/members.txt" ).Length == 0){
                //returns empty list of members.
                return getMembers();
            }

            var jsonContents = System.IO.File.ReadAllText($@"{path}/members.txt");
            List<Member> memberList = JsonConvert.DeserializeObject<List<Member>>(jsonContents);
            return memberList;
        }

        /// <summary>
        /// Creates an instance of the MemberList class.
        /// </summary>
        public MemberList(){
           members = loadMemberListFromFile();
        }

    }
}