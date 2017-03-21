using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor()
        {
            this.Name = "unknown";
            this.CourseName = "unknown";
        }

        public Instructor(string name, string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }

        public void setStudentGrade(Student student, int studentGrade)
        {
            student.setGrade(studentGrade);
        }

        public void printInfo()
        {
            System.Console.WriteLine(this.Name + " " + this.CourseName);
        }

        public void writeCourseName()
        {
            System.Console.Write(this.CourseName);
        }
    }
}