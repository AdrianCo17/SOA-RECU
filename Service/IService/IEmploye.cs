using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IEmploye
    {
        List<Empleado> GetEmployes();
        int CreateEmployes(Empleado empleado);
        int UpdateEmployes(Empleado empleado);
        int DeleteEmployes(Empleado empleado);


    }
}
