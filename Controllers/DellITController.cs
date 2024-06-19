using System.Text.Encodings.Web;
using System.Web;
using Microsoft.AspNetCore.Mvc;

public class DellItController : Controller
{
    List<string> nomesEmUmaFamilia;
    public DellItController(){
        nomesEmUmaFamilia=new();
        nomesEmUmaFamilia.Add("Sílvia");
        nomesEmUmaFamilia.Add("Edson");
        nomesEmUmaFamilia.Add("Francisco");
        nomesEmUmaFamilia.Add("Antônio");
    }

    public void Acao00(){
        Response.WriteAsync("<h1> um teste de texto sendo gerado diretamente no objeto response</h1>");
    }

    public void Acao01(){
        Console.WriteLine("Chegou uma ação no meu servidor");
    }

    public string Acao02() => "Um texto motivacional emocionante";

    public string Acao03(string id){
        return HttpUtility.HtmlEncode($"Ola {id}, seja muito bem vindo");        
    }
    [Route("acao04/{nome}")]
    public string Acao04(string nome){
        return HttpUtility.HtmlEncode($"Ola {nome}, agora eu sei q voce gosta de bolo");        
    }
    
    //URL/Home/Acao04_1?nome=algo
    public string Acao04_1(string nome){
        return HttpUtility.HtmlEncode($"Ola {nome}, agora eu sei q voce gosta de bolo");        
    }
    public string Acao05(int id){
        return $"se eu multiplicar {id} por 2, o resutaldo é {id*2}";
    }
    public string Acao06(string nome, int dataDeNascimento){
        return $"O {nome} tem {DateTime.Now.Year-dataDeNascimento} anos.";
    }

    public List<string> Acao07() => nomesEmUmaFamilia;

    public IActionResult Acao08(int id){
        switch(id){
            case 0: return NotFound();
            case 1: return NoContent();
            case 2: return Accepted();
            case 3: return BadRequest();
            default: return Ok();
        }
    }

    [HttpGet]
    public string Acao09(){
        return "Operacao do tipo get";
    }

    [HttpPost]
    public string Acao10(){
        return "Operacao do tipo post";
    }
}

