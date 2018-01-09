using System.Collections.Generic;

namespace Executor.Package
{
    public interface IDataSorter
    {
        void PrintSortedStudents(Dictionary<string, double> studentsSorted);
    }
}