using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public int InteresRate { get; set; }
        public int Salary { get; set; }
        public int OtherJob { get; set; }
        public int OtherIncome { get; set; }

        public int TotalIncome { 
            get
            {
                return InteresRate + Salary + OtherJob + OtherIncome;
            }
        }
        

    }
}