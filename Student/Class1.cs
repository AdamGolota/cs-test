using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    public class Student : IComparable<Student>
    {
        
        public Student(string _name, string _surname, Group _group = null) {
            this.name = _name;
            this.surname = _surname;
            this.group = _group == null ? null : _group;
        }


        private string name;
        private string surname;
        private Group group;

        public int CompareTo(Student s)
        {
            return s.name.CompareTo(name);
        }

        public Group getGroup()
        {
            return this.group;
        }

        public void setGroup(Group _group)
        {
            this.group.Add(this);
            this.group = _group;
        }

        public int studyYear()
        {
            return this.group.studyYear();
        }
        public void print()
        {
            Console.WriteLine(name + "\n" + surname + "\n" + group.toString());
        }
    }
}
