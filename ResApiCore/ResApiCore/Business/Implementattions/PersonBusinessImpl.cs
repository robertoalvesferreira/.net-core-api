using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ResApiCore.Data.Converters;
using ResApiCore.Data.VO;
using ResApiCore.Model;
using ResApiCore.Model.Context;
using ResApiCore.Repository;

namespace ResApiCore.Business.Implementattions
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;

        private readonly PersonConverter _converter;
        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

      

        public PersonVO Create(PersonVO person)//chega VO
        {
            var personEntity = _converter.Parse(person);//Passa para entidade
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
                
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);//Passa para entidade
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        
        }

     

    }
}
