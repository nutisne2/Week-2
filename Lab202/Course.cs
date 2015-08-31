using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string name, courseid, lecturer;
        private int maxstudent, numstudent;
        public Course()
        {
            name = "No Subject";
            courseid = "Unknown";
            lecturer = "stuff";

        }

        public Course(string name, string courseid)
        {
            this.name = name;
            this.courseid = courseid;
            lecturer = "stuff";
            maxstudent = 30;
            numstudent = 0;

        }
        public Course(string name, string courseid, string lecturer)
        {
            this.name = name;
            this.courseid = courseid;
            this.lecturer = lecturer;
            maxstudent = 30;
            numstudent = 0;
        }
        public Course(string name, string courseid, string lecturer, int maxstudent)
        {
            this.name = name;
            this.courseid = courseid;
            this.lecturer = lecturer;
            this.maxstudent = maxstudent;
            numstudent = 0;
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
        public string CourseID
        {
            get
            { return courseid; }
            set
            {
                int i;
                int a = value.Length;
                bool result = Int32.TryParse(value, out i);
                if (result && a == 6)
                {
                    
                    courseid = value;
                }
                else 
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", this.courseid);
                }
            }
        }
        public string Lecturer
        {
            get
            { return lecturer; }
            set
            {
                lecturer = value;
            }
        }
        public int MaxStudents
        {
            get
            { return maxstudent; }
            set
            {
                if (value <= 80 && value >= 0 && value >= numstudent)
                {
                    maxstudent = value;
                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!",this.courseid);
                }
                
            }
        }
        public int NumStudents
        {
            get
            { return numstudent; }
            set
            {
                if (numstudent <= value && numstudent >= 0 && value <= maxstudent)
                {
                    numstudent = value;
                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", this.courseid); 
                }
            }
        }

        public override string ToString()
        {

            return "[Course: " + Name + " (" + courseid + "), Lecturer=" + lecturer + ", has " + numstudent + " students, max="+maxstudent+"]";
        }
    }
}
