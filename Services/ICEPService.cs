using _01_Controller.Models;

namespace _01_Controller.Services;
public interface ICEPService
{
    IEnumerable<CEPViewModel> ListarTodosOsCEPs();
    CEPViewModel? PesquisarUmCEP(string CEP);
    void CadastrarCEP(CEPViewModel novoCEP);
    void ExcluirCEP(string cep);
    public void UpdateCEP(CEPViewModel CEP);

}