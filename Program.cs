using System;
using System.Collections.Generic;
using System.Linq;


namespace lm222qb_workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
          View view = new View();
          MemberList memberList = new MemberList();
          UserController userController = new UserController();

          while(userController.run(view, memberList));
        }
        
    }
}