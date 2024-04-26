using cadastro_de_contatos.Models;

namespace cadastro_de_contatos.Repository
{
    public interface IContactRepositoty
    {
        List<ContactModel> GetAll();
        
        ContactModel GetById(int id);

        ContactModel Create(ContactModel model); 

        ContactModel Update(ContactModel model);

        bool Delete(int id);
    }
}
