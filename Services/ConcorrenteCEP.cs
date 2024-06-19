using System.Collections.Concurrent;
using _01_Controller.Models;

namespace _01_Controller.Services;

public class ConcorrenteCEP : ICEPService
{
    private ConcurrentDictionary<string, CEPViewModel> listaDeCEPs;

    public ConcorrenteCEP()
    {
        listaDeCEPs = new ConcurrentDictionary<string, CEPViewModel>();
        {
            listaDeCEPs.TryAdd("90470320", new CEPViewModel() { CEP = "90470320", Logradouro = "Rua Primeiro de Janeiro", Bairro = "Três Figueiras", Cidade = "Porto Alegre", Estado = "RS" });
            listaDeCEPs.TryAdd("90150040", new CEPViewModel() { CEP = "90150040", Logradouro = "Rua Augusto Melecchi", Bairro = "Menino Deus", Cidade = "Florianópolis", Estado = "SC" });
            listaDeCEPs.TryAdd("91740000", new CEPViewModel() { CEP = "91740000", Logradouro = "Avenida da Cavalhada", Bairro = "Cavalhada", Cidade = "Curitiba", Estado = "PR" });
            listaDeCEPs.TryAdd("90035005", new CEPViewModel() { CEP = "90035005", Logradouro = "Rua Ramiro Barcelos", Bairro = "Independência", Cidade = "Birigui", Estado = "SP" });
        };
    }
    public void CadastrarCEP(CEPViewModel novoCEP)
    {
        listaDeCEPs.TryAdd(novoCEP.CEP, novoCEP);
    }

    public IEnumerable<CEPViewModel> ListarTodosOsCEPs()
    {
        return listaDeCEPs.Values;
    }

    public CEPViewModel? PesquisarUmCEP(string CEP)
    {
        listaDeCEPs.TryGetValue(CEP, out CEPViewModel? result);
        return result;
    }

    public void ExcluirCEP(string CEP)
    {
        listaDeCEPs.TryRemove(CEP, out _);
    }

    public void UpdateCEP(CEPViewModel CEP)
    {
        CEPViewModel? cep = PesquisarUmCEP(CEP.CEP);
        if (cep != null)
        {
            listaDeCEPs.TryUpdate(CEP.CEP, CEP, cep!);
        }
    }
}