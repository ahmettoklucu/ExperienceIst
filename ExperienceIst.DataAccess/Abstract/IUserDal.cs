﻿using ExperienceIst.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceIst.DataAccess.Abstract
{
    public interface IUserDal
    {
        User Get(Expression<Func<User, bool>> filter);
    }
}
