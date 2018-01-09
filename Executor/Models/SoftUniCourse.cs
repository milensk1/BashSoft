using System;
using System.Collections.Generic;
using Executor.Exceptions;
using Executor.Package;

namespace Executor.Models
{
    public class SoftUniCourse : Course
    {
        public const int NumberOfTasksOnExam = 5;
        public const int MaxScoreOnExamTask = 100;

        private string name;

        private Dictionary<string, Student> studentsByName;

        public SoftUniCourse(string name)
        {
            this.Name = name;
            this.studentsByName = new Dictionary<string, Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.name = value;
            }
        }

        public IReadOnlyDictionary<string, Student> GetStudentByName
        {
            get
            {
                return this.studentsByName;
            }
        }

        public void EnrollStudent(Student softUniStudent)
        {
            if (this.studentsByName.ContainsKey(softUniStudent.UserName))
            {
                throw new DuplicateEntryInStructureException(softUniStudent.UserName, this.Name);
            }

            this.studentsByName.Add(softUniStudent.UserName, softUniStudent);
        }

        public int CompareTo(Course other) => String.Compare(this.Name, other.Name, StringComparison.Ordinal);

        public override string ToString() => this.Name;
    }
}