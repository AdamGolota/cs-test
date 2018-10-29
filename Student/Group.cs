using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    public class Group : INamedGroup<Student>
    {
        public Group(string _groupName)
        {
            if (_groupName.Length == 0)
            {
                this.Name = "Group not set";
            }
            this.Name = isValid(_groupName) ? _groupName : "Invalid group name";
        }
        public string Name { get; set; }
        public Student this[int i]
        {
            get => students[i];
            set => students[i] = value;
        }
        

        private Student[] students = new Student[1];


        public void Add(Student _student)
        {
            if (_student.getGroup() == this)
                return;

            // Copy the array and add new student as a first element
            int len = students.Length + 1;
            Student[] newStudents = new Student[len];
            newStudents[0] = _student;
            for (int i = 1; i < len; i++)
            {
                newStudents[i] = this.students[i - 1];
            }

            // Deal with group reference
            var studentGroup = _student.getGroup();
            if (studentGroup != null)
            {
                studentGroup.Remove(_student);
            }
            _student.setGroup(this);
        }

        public void Remove(Student _student)
        {
            int len = students.Length;
            if (len == 0)
                return;
            Student[] newStudents = new Student[len - 1];
            int i, j;

            // Copy elements to a new arr till the student is found
            for (i = 0; students[i] != _student && i < len; i++)
            {
                newStudents[i] = students[i];
            }

            // Copy the rest of array, missing out the student
            for (j = i++; i < len; i++, j++)
            {
                newStudents[j] = students[i];
            }

            this.students = newStudents;
            _student.setGroup(null);
        }

        public int studyYear()
        {
            if (Name.Length == 0)
            {
                return 1;
            }
            int startYear = Name[3] - 48;
            int year = (DateTime.Now.Year - startYear) % 10;
            if (DateTime.Now.Month > 8)
                year++;
            if (year > 4)
                return 0;
            return year;
        }
        public string toString()
        {
            return this.Name;
        }
        private bool isValid(string group)
        {
            return
                group.Length >= 5   &&
                isLiteral(group[0]) &&
                isLiteral(group[1]) &&
                group[2] == '-'     &&
                isNumeric(group[3]) &&
                isNumeric(group[4]) && 
                group[4] >= '1';
        }
        private bool isLiteral(char c)
        {
            return c >= 'А' && c <= 'Я' || c == 'І' || c == 'Ї';
        }
        private bool isNumeric(char c)
        {
            return c >= '0' || c <= '9';
        }
    }
}
