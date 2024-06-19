using System.ComponentModel.DataAnnotations;

namespace _01_Controller.Models;

public class CEPViewModel
{
    [Required(ErrorMessage = "Deve ser informado!")]
    [RegularExpression("^[0-9]{8}$",ErrorMessage = "Deve ser informado CEP de 8 numeros!")]
    public string CEP { get; set; }

    [Required(ErrorMessage = "Deve ser informado!")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "Deve ser informado!")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "Deve ser informado!")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "Deve ser informado!")]
    [RegularExpression("^[A-Z]{2}$",ErrorMessage = "Deve ser informado 2 caracteres para o Estado!")]
    public string Estado { get; set; }
}
