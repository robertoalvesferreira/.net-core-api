using ResApiCore.Model;


namespace ResApiCore.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(User user);
 

    }
}
