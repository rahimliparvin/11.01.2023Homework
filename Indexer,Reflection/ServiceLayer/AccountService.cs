using ServiceLayer.Exceptions;
using ServiceLayer.Helpers;
using ServiceLayer.Helpers.Constans;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class AccountService : IAccountService
    {
        public string Register(string username, string email,string password)
        {
            try
            {

                var result = GetAllEmail();
                if (result.Contains(email))
                {
                    throw new RegisterException(ResponsMessages.InvalidRegisterMessage);
                }
               
                return "Register Success";
            }


            catch (Exception ex)
            {
              return ex.Message;
            }
        }

        private List<string> GetAllEmail()
        {
            return new List<string>() { "pervin12@gmail.com", "ali@code.edu.az", "mirze@mail.com" };
        }
    }
}


