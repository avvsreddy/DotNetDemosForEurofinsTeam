using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace DelegatesNLambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cleint Developer 1
            //FilterDelegate filter = new FilterDelegate(NoFilter);
            //ProcessManager.ShowProcessList(NoFilter);

            // Anonymous Delegates
            ProcessManager.ShowProcessList( delegate
                {
                return true;
                });

            // Lambdas - Light Weight Syntax for Anonymous Delegates
            ProcessManager.ShowProcessList( (_) =>
            {
                return true;
            });

            // Client 2

            //Anoymous Delegates
            ProcessManager.ShowProcessList(delegate(Process p) {
                return p.ProcessName.StartsWith("S");
            });

            // Lambda - Statement 
            ProcessManager.ShowProcessList( (Process p) => 
            {
                return p.ProcessName.StartsWith("S");
            });


            // Lambda - Expression
            ProcessManager.ShowProcessList((Process p) =>
            
                p.ProcessName.StartsWith("S")
            );

            // Lambda - Expression
            ProcessManager.ShowProcessList(p => p.ProcessName.StartsWith("S"));


            // Client 3
            ProcessManager.ShowProcessList( (Process p) =>{
                if (p.WorkingSet64 >= 100 * 1024 * 1024) return true;
                else
                    return false;
            });

            ProcessManager.ShowProcessList( p => p.WorkingSet64 >= 100 * 1024 * 1024 );
        }

        //// Client 1
        //public static bool NoFilter(Process p, int a, int b, string str)
        //{
        //    return true;
        //}


        //// Client 2

        //public static bool FilterByName(Process p)
        //{
        //    return p.ProcessName.StartsWith("S");
        //}

        //// Client 3
        //public static bool FilterByMem(Process p)
        //{
        //    if (p.WorkingSet64 >= 100 * 1024 * 1024) return true;
        //    else
        //        return false;
        //}

    }





    // Library Developer 1


    public delegate bool FilterDelegate(Process p);
    public class ProcessManager
    {
        public static void ShowProcessList(FilterDelegate filter)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (filter(process))
                    Console.WriteLine(process.ProcessName);
            }
        }
    }
}
