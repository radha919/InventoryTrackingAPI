using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.EAL.Models;
using Microsoft.AspNetCore.Identity;

namespace Inventory.DAL.Repositories
{
    public interface IUserInfoRepository
    {
        void Register(UserInfo userInfo);
        UserInfo Login(UserInfo user);
    }
}


 
    
