﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }

        public void setTeacher(Instructor teacher)
        {
            this.Teacher = teacher;
        }

        public void setGrade(int studentgrade2)
        {
            this.Grade = studentgrade2;
        }

        public void printInfo()
        {
            System.Console.WriteLine("=");
            System.Console.WriteLine("name: " + this.Name + " grade: " + this.Grade);
            this.Teacher.printInfo();
        }
    }
}