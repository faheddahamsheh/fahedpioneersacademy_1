using Domains.DTOs;
using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.interfaces
{
    public interface IUser
    {

        void Add(AddUserRequest user);
        bool Login(string EmailAddress, string password);

    }
}
