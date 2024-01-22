using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _19._01.Dosie;

namespace _19._01
{
    class Dosie
    {
        public class Student
        {
            private string name;
            private string gender;
            private int year;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Gender
            {
                get { return gender; }
                set
                {
                    int male = 0;
                    int fem = 0;

                    foreach (Student student in gender)
                    {
                        if (student.Gender.ToLower() == "male")
                        {
                            male++;
                        }
                        else if (student.Gender.ToLower() == "female")
                        {
                            fem++;
                        }
                    }
                }
            }

            public int Year
            {
                get { return year; }
                set{ year = value; }
            }

            public Student(string name, string gender, int year)
            {
                Name = name;
                Gender = gender;
                Year = year;
            }
        }
    }
}
