﻿using System;
using System.Collections.Generic;
using System.Linq;
using Executor.Exceptions;
using Executor.Package;

namespace Executor.Models
{
    public class SoftUniStudent : Student
    {
        private string userName;
        private Dictionary<string, Course> enrolledCourses;
        private Dictionary<string, double> marksByCourseName;

        public string UserName
        {
            get
            {
                return this.userName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.userName = value;
            }
        }

        public IReadOnlyDictionary<string, Course> EnrolledCourses
        {
            get
            {
                return this.enrolledCourses;
            }
        }

        public IReadOnlyDictionary<string, double> MarksByCourseName
        {
            get
            {
                return this.marksByCourseName;
            }
        }

        public SoftUniStudent(string userName)
        {
            this.UserName = userName;
            this.enrolledCourses = new Dictionary<string, Course>();
            this.marksByCourseName = new Dictionary<string, double>();
        }

        public void EnrollInCourse(Course softUniCourse)
        {
            if (this.EnrolledCourses.ContainsKey(softUniCourse.Name))
            {
                throw new DuplicateEntryInStructureException(this.UserName, softUniCourse.Name);
            }

            this.enrolledCourses.Add(softUniCourse.Name, softUniCourse);
        }

        public void SetMarkOnCourse(string courseName, params int[] scores)
        {
            if (!this.EnrolledCourses.ContainsKey(courseName))
            {
                throw new KeyNotFoundException(ExceptionMessages.NotEnrolledInCourse);
            }

            if (scores.Length > SoftUniCourse.NumberOfTasksOnExam)
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumberOfScores);
            }

            this.marksByCourseName.Add(courseName, this.CalculateMark(scores));
        }

        public string GetMarkForCourse(string courseName)
        {
            return string.Format($"{this.userName} - {this.MarksByCourseName[courseName]}");
        }

        private double CalculateMark(int[] scores)
        {
            double percentageOfSolvedExam = scores.Sum() / (double)(SoftUniCourse.NumberOfTasksOnExam * SoftUniCourse.MaxScoreOnExamTask);
            double mark = percentageOfSolvedExam * 4 + 2;
            return mark;
        }

        public int CompareTo(Student other) => String.Compare(this.UserName, other.UserName, StringComparison.Ordinal);

        public override string ToString() => this.UserName;
    }
}