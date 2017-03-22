namespace Lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

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
            System.Console.WriteLine("intructor: " + this.Name + " course: " + this.CourseName + " ");
        }
    }
}