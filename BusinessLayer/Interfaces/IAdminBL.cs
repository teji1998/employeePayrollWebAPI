﻿using CommonLayer.RequestModel;
using CommonLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IAdminBL
    {
        EmployeeModel AdminLogin(AdminModel login);
        List<EmployeeModel> GetAllEmployee();
        bool RegisterAdmin(RegisterModel admin);
    }
}
