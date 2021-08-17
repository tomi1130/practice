using System;

namespace Pra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(); 
            Person p2 = new Person();
            p1.name = "田中";
            p1.age = 20;
            p1.ShowAgeAndName();

            p2 = new Person();
            p2.SetAgeName("a", 541);
            p2.ShowAgeAndName();
        }
    }
}
