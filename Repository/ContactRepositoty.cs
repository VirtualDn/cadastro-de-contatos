using cadastro_de_contatos.Data;
using cadastro_de_contatos.Models;

namespace cadastro_de_contatos.Repository
{


    public class ContactRepositoty : IContactRepositoty
    {
        private readonly Connection _db;
        public ContactRepositoty(Connection db)
        {
            _db = db;
        }

        public List<ContactModel> GetAll()
        {
            return _db.Contact.ToList();
        }

        public ContactModel Create(ContactModel model)
        {
            _db.Contact.Add(model);
            _db.SaveChanges();
            return model;
        }

        public ContactModel GetById(int id) => _db.Contact.FirstOrDefault(x => x.Id == id);

        public ContactModel Update(ContactModel model)
        {
            ContactModel att = GetById(model.Id);
            if (att == null) throw new System.Exception("Houve um erro na atualizaçao do contato");
            att.Phone = model.Phone;
            att.Email = model.Email;
            att.Name = model.Name;
            _db.Contact.Update(att);
            _db.SaveChanges();              
            return att;
        }

        public bool Delete(int id)
        {
            ContactModel att = GetById(id);
            if (att == null) throw new System.Exception("Houve um erro na deleçao do contato");
            _db.Remove(att);
            _db.SaveChanges();
            return true;
        }
    }
}
