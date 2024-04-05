using ExperienceIst.Bussiness.Abstract;
using ExperienceIst.Bussiness.Concrate.RequestModele;
using ExperienceIst.Bussiness.Concrate.ResultModele;
using ExperienceIst.Bussiness.Concrate.Security;
using ExperienceIst.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceIst.Bussiness.Concrate
{
    public class UserManager :IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public LoginResultModel Login(LoginRequestModel loginRequest)
        {
            var loginResult = new LoginResultModel();
            loginResult.Success = false;
            loginResult.Message = "";
            loginResult.Token = null;

            try
            {
                var user = _userDal.Get(p => p.UserName.Equals(loginRequest.UserName, StringComparison.Ordinal));
                if (user != null)
                {
                    if (loginRequest.Password!= user.Password) 
                    {
                        loginResult.Message = "Password denied!";
                        user = null;
                    }
                    else
                    {
                        loginResult.Message = "Success";
                        loginResult.Success = true;
                        user.PhoneNumber = user.PhoneNumber;
                        user.EMail = user.EMail;
                        user.Id = user.Id;
                        user.UserName = user.UserName;
                        user.Password = user.Password;
                        var generateTokenResult = new LoginResultModel();
                        TokenProcess.GenerateToken(ref loginResult, user, 20);

                    }
                }
                else
                {
                    loginResult.Message = "This user is not registered!";
                }
            }
            catch (Exception e)
            {
                loginResult.Success = false;
                loginResult.Message = "Error! Contact the system manager!";
            }
            return loginResult;
        }
    }
}

