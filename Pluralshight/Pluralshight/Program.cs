using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralshight
{
    public delegate void WorkPerformedHandler(int hrs, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);
            //del1(5, WorkType.GenerateReports);
            //del2(10, WorkType.GoToMeeting);
            
            del1 += del2 + del3;
            DoWork(del1);
            Console.Read();

        }
        static void DoWork(WorkPerformedHandler del)
        {
            del(7, WorkType.Golf);
        }
        static void WorkPerformed1(int hrs, WorkType WorkType)
        {
            Console.WriteLine("WorkPerformed1 called for " + hrs + " Hours");
        }
        static void WorkPerformed2(int hrs, WorkType WorkType)
        {
            Console.WriteLine("WorkPerformed2 called for " + hrs + " Hours");
        }
        static void WorkPerformed3(int hrs, WorkType WorkType)
        {
            Console.WriteLine("WorkPerformed3 called for " + hrs + " Hours");
        }
    }
    public enum WorkType
    {
        GoToMeeting,
        Golf,
        GenerateReports
    }
}
