using Domains.DTOs;
using Domains.Entities;
using Domains.interfaces;
using infrastractures;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService : IUser
    {
        private List<User> _users;

        public UserService()
        {
            if (_users == null) _users = new List<User>();

        }

        public void Add(AddUserRequest Request)
        {
            var UserData = Request.Adapt<User>();
            UserData.CreatedDate = DateTime.Now;
            UserData.Id = Guid.NewGuid();
            UserData.IsDeleted = false;
            UserData.Usertype = Domains.Enums.UserTypeEnum.user;
            UserData.Password = EncryptionHelper1.Encryption(Request.Password);
            _users.Add(UserData);
            var username = "fahed faeq dahamsheh";
            var l = username.GetStringCount();
        }

        public bool Login(string EmailAddress, string password)
        {
            var user = _users.Where(q => q.EmailAddress == EmailAddress).FirstOrDefault();
            if (user != null)
            {
                var iscorrect = EncryptionHelper1.verify(password, user.Password);
                if (iscorrect) return true; else return false;

            }
            else return false;
        }
        public GetUserInfoResponse GetUserInfo(Guid id)
        {
            var result = _users.Where(q => q.Id == id)
                .Select(q => new GetUserInfoResponse()
                {
                    FullName = q.FullName
                ,
                    UserId = q.Id



                })
                .FirstOrDefault();
            return result;

        }
        //        public Tuple<int, string> getuserinfo()
        //        {
        //return Tuple.Create<>}
    }
}

