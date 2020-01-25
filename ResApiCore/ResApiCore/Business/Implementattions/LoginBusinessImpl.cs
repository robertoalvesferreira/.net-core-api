using System;
using ResApiCore.Model;
using ResApiCore.Repository;
using ResApiCore.Security.Configuration;

namespace ResApiCore.Business.Implementattions
{
    public class LoginBusinessImpl : ILoginBusiness
    {
        private IUserRepository _repository;
        private SigningConfigurations _signingConfigurations;
        private TokenConfiguration _tokenConfiguration;
     
        public LoginBusinessImpl(IUserRepository repository , 
            SigningConfigurations signingConfigurations,
            TokenConfiguration tokenConfiguration)
        {
            _repository = repository;
            _signingConfigurations = signingConfigurations;
            _tokenConfiguration = tokenConfiguration;
        }

        public object FindByLogin(User user)
        {
            bool credentialsIsValid = false;
            if(user != null && !string.IsNullOrWhiteSpace(user.Login))
            {
                var baseUser = _repository.FindByLogin(user.Login);
                credentialsIsValid = (
                    baseUser != null && user.Login == baseUser.Login &&
                    user.AccessKey == baseUser.AccessKey);
            }
            if (credentialsIsValid)
            {
                return SuccessObject();
            }
            else
            {
                return ExceptionObject();
            }
        }

        private object ExceptionObject()
        {
            throw new NotImplementedException();
        }

        private object SuccessObject()
        {
            throw new NotImplementedException();
        }
    }
}
