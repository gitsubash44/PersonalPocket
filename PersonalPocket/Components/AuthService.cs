using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPocket.Components
{
    public class AuthService
    {
        public bool IsLoggedIn { get; private set; } = false;
        public string LoggedInUser { get; private set; } = string.Empty;
        public string UserCurrency { get; private set; } = string.Empty;

        public Task Login(string username, string currency)
        {
            IsLoggedIn = true;
            LoggedInUser = username;
            UserCurrency = currency;
            return Task.CompletedTask;
        }

        public Task Logout()
        {
            IsLoggedIn = false;
            LoggedInUser = string.Empty;
            UserCurrency = string.Empty;
            return Task.CompletedTask;
        }
    }

}
