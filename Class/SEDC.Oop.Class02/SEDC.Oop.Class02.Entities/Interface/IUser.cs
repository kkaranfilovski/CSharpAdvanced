using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Entities.Interface
{
    public interface IUser
    {
        int Id { get; set; }
        string GetID();
    }
}
