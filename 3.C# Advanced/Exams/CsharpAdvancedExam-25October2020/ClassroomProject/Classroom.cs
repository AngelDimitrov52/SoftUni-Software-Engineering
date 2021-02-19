using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        private int capacity;

        public Classroom(int capacity)
        {
            this.capacity = capacity;
            Capacity = capacity;
            students = new List<Student>(Capacity);
        }
        public int Capacity { get; }
        public int Count { get => students.Count; }

        public string RegisterStudent(Student student)
        {
            if (students.Count < capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            foreach (var item in students)
            {
                if (item.FirstName == firstName)
                {
                    if (item.LastName == lastName)
                    {
                        students.Remove(item);
                        return $"Dismissed student {firstName} {lastName}";
                    }
                }
            }
            return "Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            bool flag = false;
            foreach (var item in students)
            {
                if (item.Subject == subject)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                    flag = true;
                }
            }
            if (flag == false)
            {
                return "No students enrolled for the subject";
            }

            return sb.ToString().Trim();
        }
        public int GetStudentsCount()
        {
            return Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            foreach (var item in students)
            {
                if (item.FirstName == firstName)
                {
                    if (item.LastName == lastName)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
