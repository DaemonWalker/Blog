using Blog.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data
{
    public interface IAccountHelper
    {
        void Create(AccountModel account);
        bool Login(AccountModel account);
        bool ChangeProfile(AccountModel account);
    }
}
