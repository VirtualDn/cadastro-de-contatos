using System.ComponentModel.DataAnnotations;

namespace cadastro_de_contatos.Models
{
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Digita o name do contato"), StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digita o e-mail do contato"), StringLength(300)]
        [EmailAddress(ErrorMessage = "O e-mail nâo e valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digita o celular do contato"), StringLength(12)]
        [Phone(ErrorMessage = "O celular esta invalido")]
        public string Phone { get; set; }
    }
}
