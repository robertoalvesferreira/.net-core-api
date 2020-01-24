using ResApiCore.Data.VO;
using ResApiCore.Model;
using System.Collections.Generic;


namespace ResApiCore.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
 

    }
}
