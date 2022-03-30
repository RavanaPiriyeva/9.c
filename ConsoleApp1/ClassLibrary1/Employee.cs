using System;

namespace ClassLibrary1
{
    public class Employee
    {


        private string _name;
        private string _surname;
        public int _salary;
        public string Name { get { return _name; } set { if (IsLetterAndUpper(value)) { _name = value; } } }
        public string Surname { get { return _surname; } set { if (IsLetterAndUpper(value)) { _surname = value; } } }
        public int Salary 
        {
            get { return _salary; } 
            set 
            { 
                if (value >= 250)
                {
                    _salary = value;
                } 
                else 
                { 
                    Console.WriteLine($"{Name} adli iscinin maasi 250 den azdir."); 
                } 
            } 
        }


        public bool IsLetterAndUpper(string name)
        {
            foreach (var item in name)
            {

                if (char.IsUpper(name[0])  && char.IsLetter(item))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
