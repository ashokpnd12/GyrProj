using GyrProj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyrProj.Context
{
    public class DatabaseInitializer: CreateDatabaseIfNotExists<context>
    {
        protected override void Seed(context context)
        {
            var emp = new List<EmpMaster>()
            {
                new EmpMaster { id=1,name="Akshay Kumar",Education="",age=null,technical_exp="",Last_co_worked=""},
                new EmpMaster { id=2,name="Kishore B",Education="",age=null,technical_exp="",Last_co_worked=""},
                new EmpMaster { id=3,name="Jack richer",Education="",age=null,technical_exp="",Last_co_worked=""},
                new EmpMaster { id=4,name="Namrata Mondal",Education="",age=null,technical_exp="",Last_co_worked=""},
                new EmpMaster { id=5,name="Suman Choudhury",Education="",age=null,technical_exp="",Last_co_worked=""},
                new EmpMaster { id=6,name="Saraswati Tripathi",Education="",age=null,technical_exp="",Last_co_worked=""},
                new EmpMaster { id=7,name="Priyanka SV",Education="",age=null,technical_exp="",Last_co_worked=""},
                new EmpMaster { id=8,name="Samar Srivastav",Education="",age=null,technical_exp="",Last_co_worked=""},
            };
            emp.ForEach(x => context.Employees.Add(x));
            context.SaveChanges();
        }
    }
}
