using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    class test
    {
        static void Main(string[] args)
        {
             Member member = new Member("lowe",121221, 2132);
             member.addBoat(BoatType.Sailboat, "sadas", 123);
             Console.WriteLine(member.ToString());
             foreach(Boat boat in member.getBoats()){
                 Console.WriteLine(boat.ToString());
             }
        }
    }
}