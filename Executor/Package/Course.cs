using System;
using System.Collections.Generic;

namespace Executor.Package
{
    public interface Course : IComparable<Course>
    {
        string Name { get; }

        IReadOnlyDictionary<string, Student> GetStudentByName { get; }

        void EnrollStudent(Student student);
    }
}