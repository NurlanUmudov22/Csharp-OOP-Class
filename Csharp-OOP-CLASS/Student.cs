using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_CLASS
{
    internal class Student
    {

        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone = "566546464";


        //public void ShowText()
        //{
        //    string text = "hello pb101";
        //    Console.WriteLine(text);
        //}

        public string GetFullName()
        {
            return name + " " + surname;
        }






        public string GetFullDatas()
        {
            string fullData = $"Name: {name}, Surname: {surname}, " +
                $" Age: {age}, Address: {address}, Phone: {phone}";

            return fullData;
        }








    }
}
