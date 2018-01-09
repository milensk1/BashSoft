using System;
using System.Collections.Generic;

namespace Executor.Package
{
    public interface Student : IComparable<Student>
    {
        string UserName { get; }

        IReadOnlyDictionary<string, Course> EnrolledCourses { get; }

        IReadOnlyDictionary<string, double> MarksByCourseName { get; }

        void EnrollInCourse(Course softUniCourse);

        void SetMarkOnCourse(string courseName, params int[] scores);

        string GetMarkForCourse(string courseName);
    }
}