using Inventory.DAL.Repositories;
using Inventory.DAL.Data;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Inventory.DAL.Repositories
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private InventoryDbcontext _inventoryDbContext;
        public UserInfoRepository(InventoryDbcontext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }
        public UserInfo Login(UserInfo user)
        {
            UserInfo userInfo = null;
            var result = _inventoryDbContext.userInfo.Where(obj => obj.Email == user.Email && obj.Password == user.Password).ToList();
            if (result.Count > 0)
            {
                userInfo = result[0];
            }
            return userInfo;
        }

        public void Register(UserInfo userInfo)
        {
            _inventoryDbContext.Add(userInfo);
            _inventoryDbContext.SaveChanges();
        }
    }
}

 

 
    

