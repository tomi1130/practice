using System;
using System.Collections.Generic;
using System.Text;

namespace Pra1
{
    class Person
    {
        //名前
        public string name = "";

        public int age = 0;

        public void ShowAgeAndName() 
        {
            Console.WriteLine("名前: {0} 年齢:{1}", name, age);
        }

        public void SetAgeName(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
