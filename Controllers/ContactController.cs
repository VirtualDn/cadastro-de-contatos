using cadastro_de_contatos.Models;
using cadastro_de_contatos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_de_contatos.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepositoty _repositoty;

        public ContactController(IContactRepositoty repositoty)
        {
            _repositoty = repositoty;
        }


        public IActionResult Index()
        {
            List<ContactModel> list = _repositoty.GetAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repositoty.Create(contact);
                    TempData["menssageSucess"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contact);
            }
            catch (Exception erro)
            {
                TempData["menssageSucess"] = $"Ops!! nao foi possivel cadastrado contato, tente novamente. detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        public IActionResult Edit(int id)
        {
            ContactModel model = _repositoty.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ContactModel contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repositoty.Update(contact);
                    TempData["menssageSucess"] = "Contato Atualizado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contact);
            }
            catch (Exception erro)
            {
                TempData["menssageErr"] = $"Ops!! nâo foi possivel atualizar contato, tente novamente. detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        public IActionResult Delete(int id)
        {
            try
            {
                _repositoty.Delete(id);
                TempData["menssageSucess"] = "Contato deletado com sucesso";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {

                TempData["menssageErr"] = $"Ops!! nâo foi possivel deletar contato, tente novamente. detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");

            }


        }
    }
}
