using ExperienceIst.Bussiness.Concrate.RequestModele;
using ExperienceIst.Bussiness.Concrate.ResultModele;
using ExperienceIst.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceIst.Bussiness.Abstract
{
    public interface IUserService
    {
        LoginResultModel Login(LoginRequestModel loginRequest);
       
    }
}
