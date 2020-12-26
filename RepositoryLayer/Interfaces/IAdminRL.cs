using CommonLayer.RequestModel;
using CommonLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IAdminRL
    {
        EmployeeModel AdminLogin(AdminModel login);
        List<EmployeeModel> GetAllEmployee();
        bool RegisterAdmin(RegisterModel admin);
    }
}
