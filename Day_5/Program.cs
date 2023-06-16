using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeBook ebs = new EmployeeBook();

             ebs.TargetA();
             ebs.TargetB();
             ebs.TargetC();
             ebs.TargetD();
             ebs.TargetE();
             ebs.TargetF();
             ebs.Index();
             ebs.Wagesminimal();
             ebs.Wagesmaximal();
             ebs.Tasks();
             ebs.Add();
             ebs.Del();
             ebs.Changes();
             ebs.PoOtdelam();
        }
    }
}