using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {

        private string name;
        private string studentid;
        private int _age = 0;
        private int yearofbirth;
        private bool status;
        
        public Student()
        {
            name = "John Doe";
            yearofbirth = 1995;
            status = false;
            studentid = "Unknown";
        }
        public Student(string name, string studentid)
        {

            this.name = name;
            this.studentid = studentid;

            yearofbirth = 1995;
            status = true;
        }
        public Student(string name, string studentid, int yearofbirth)
        {

            this.name = name;
            this.studentid = studentid;
            this.yearofbirth = yearofbirth;
            status = true;
        }
        public Student(string name, string studentid, int yearofbirth, bool status)
        {

            this.name = name;
            this.studentid = studentid;
            this.yearofbirth = yearofbirth;
            this.status = status;
        }
        public string Name
        {
            get
            { return name; }
            set
            {
                name = value;
            }
        }
        public int YearOfBirth
        {
            get
            {
                return yearofbirth;
            }
            set
            {
                int x = yearofbirth;
                yearofbirth = value;
                if (yearofbirth >= 1950 && yearofbirth <= 2000)
                {
                    yearofbirth = value;
                }
                else
                {

                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", this.studentid);

                    yearofbirth = x;
                }
            }
        }
        public bool isActive
        {
            get
            {
                return status;
            }
            set
            {
                status = true;
            }
        }
        public int Age
        {

            get
            {
                int todayyears = DateTime.Now.Year;
                _age = todayyears - YearOfBirth;


                return _age;
            }

        }
        public override string ToString()
        {
            string x;
            if (status == true)
                x = "is";
            else
            {
                x = "is NOT";
            }
            return "Student : " + Name + "(" + studentid + ")" + ", Age = " + Age + ",  " + x + " active Stdent";
        }
    }
}
