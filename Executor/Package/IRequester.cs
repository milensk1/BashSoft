using System.Collections.Generic;

namespace Executor.Package
{
    public interface IRequester
    {
        void GetStudentScoresFromCourse(string courseName, string username);

        void GetAllStudentsFromCourse(string courseName);

        ISimpleOrderedBag<Course> GetAllCoursesSorted(IComparer<Course> cmp);

        ISimpleOrderedBag<Student> GetAllStudentsSorted(IComparer<Student> cmp);
    }
}