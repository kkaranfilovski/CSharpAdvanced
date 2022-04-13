using SEDC.Oop.Class05.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Services.Interfaces
{
    public interface IUser
    {
        public void LogIn();
        public void ChangePassword();
    }
}
