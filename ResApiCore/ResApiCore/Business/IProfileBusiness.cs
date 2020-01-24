using ResApiCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResApiCore.Business
{
    public interface IProfileBusiness
    {
        Profile Create(Profile profile);
        Profile FindById(long id);
        List<Profile> FindAll();
        Profile Update(Profile profile);
        void Delete(long id);

    }
}
