using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student
    {
        private Guid _id = Guid.NewGuid();
        public Guid Id
         {
             get { return _id; }
             set { _id = value; }
         }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GroupName { get; set; }
        public double? AverageMark { get; set; }
    }
}
