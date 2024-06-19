using _01_Controller.Models;
using _01_Controller.Services;
using Microsoft.AspNetCore.Mvc;

public class CEPController : Controller
{
    private ICEPService cepService;
    public CEPController(ICEPService ics)
    {
        cepService = ics;
    }

    public IActionResult Lista()
    {
        return View(cepService.ListarTodosOsCEPs());
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(CEPViewModel novoCEP)
    {
        if (ModelState.IsValid)
        {
            cepService.CadastrarCEP(novoCEP);
            return RedirectToAction("Lista");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Editar(string? id)
    {
        CEPViewModel? cvm = cepService.PesquisarUmCEP(id!);
        return View(cvm);
    }

    [HttpPost]
    public IActionResult Editar(CEPViewModel novoCEP)
    {
        if (ModelState.IsValid)
        {
            cepService.UpdateCEP(novoCEP);
            return RedirectToAction("Lista");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Excluir(string? id)
    {
        CEPViewModel? cvm = cepService.PesquisarUmCEP(id!);
        return View(cvm);
    }

    [HttpPost]
    public IActionResult ExcluirPost(string? CEP)
    {
        if (CEP != null)
        {
            cepService.ExcluirCEP(CEP);
            return RedirectToAction("Lista");
        }
        return View();
    }
}
