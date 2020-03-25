using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{

    public class IncomeRepository
    {
        private static Income[] _income = new Income[]
    {
        new Income()
            {  
                Id=1,
                Details = "Budget1",
                InteresRate = 50,
                Salary = 8200,
                OtherJob = 20,
                OtherIncome = 230,
            },
        new Income()
            {   Id=2,
                Details = "Budget2",
                InteresRate = 50,
                Salary = 1200,
                OtherJob = 220,
                OtherIncome = 450,
            },
        new Income()
            {   
                Id=3,
                Details = "Budget3",
                InteresRate = 250,
                Salary = 1700,
                OtherJob = 1220,
                OtherIncome = 20,
            }
    };
        public Income GetIncome(int id)
        {
            Income incomeToReturn = null;
            
            foreach (var income in _income)
            {
                if ( income.Id == id)
                {
                    incomeToReturn = income;

                    break;
                }
            }
            return incomeToReturn;
        }

    }
}
    
