﻿using ResApiCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResApiCore.Repository
{
    public interface IUserRepository
    {
        User FindByLogin(string id);


    }

}

