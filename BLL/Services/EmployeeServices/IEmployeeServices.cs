using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Services.EmployeeServices
{
   public interface IEmployeeServices
    {
        int Add(EmployeeVM emp);
        int Edit(EmployeeVM emp);
        int  Delete(EmployeeVM emp);
    }
}
