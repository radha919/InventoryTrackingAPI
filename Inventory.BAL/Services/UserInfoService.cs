using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.DAL.Repositories;
using Inventory.EAL.Models;

namespace Inventory.BAL.Services
{
    public class UserInfoService:IUserInfoRepository
    {
        private IUserInfoRepository _userInfoRepository;
        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        public void Register(UserInfo userInfo)
        {
            _userInfoRepository.Register(userInfo);
        }
        public UserInfo Login(UserInfo userInfo)
        {
            return _userInfoRepository.Login(userInfo);
        }
    }
}

 
 

        