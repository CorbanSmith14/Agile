using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox13
{
    internal class Student
    {
        private string studentId;
        private string name;
        private int score;
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string Name
        { 
            get { return name; } 
            set {  name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public Student(string studentId, string name, int score)
        {
            this.studentId = studentId;
            this.name = name;
            this.score = score;
        }
        public char GetLetterGrade()
        {
            char letterGrade;
            if (score>=90)
            {
                letterGrade = 'A';
            }
            else if (score>=80)
            {
                 letterGrade = 'B';
            }
            else if (score>=70)
            {
                letterGrade = 'C';
            }
            else if (score>=60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }
            return letterGrade;
        }
        public override string ToString()
        {
            string str;
            str = $"{StudentId}\n{Name}\n{score}";
            return str;
        }


    }
}
