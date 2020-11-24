using System;
using System.Collections.Generic;

namespace DapperDanORM
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); //Stubbed out method
    }
}
