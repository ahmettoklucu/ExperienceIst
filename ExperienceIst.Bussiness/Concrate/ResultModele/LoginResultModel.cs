using ExperienceIst.Bussiness.Concrate.Security;
using ExperienceIst.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceIst.Bussiness.Concrate.ResultModele
{
    public class LoginResultModel:ResultModel
    {
        public Token Token { get; set; }
        public User User { get; set; }
    }
}
