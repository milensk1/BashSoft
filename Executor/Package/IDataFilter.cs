using System.Collections.Generic;

namespace Executor.Package
{
    public interface IDataFilter
    {
        void PrintFilteredStudents(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentsToTake);
    }
}