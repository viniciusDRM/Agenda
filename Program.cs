using System.IO;
using System.Text.Json;
namespace agenda_beta_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string path = "contatos.json";
        string lista = File.ReadAllText("contatos.json");
            
          List<Contato> contatos = JsonSerializer.Deserialize<List<Contato>>(lista);


           Contato teste = new Contato("teste1","555555");
            Contato teste2 = new Contato("teste2","101506");
           Contato.AdicionarContato(contatos,teste);
            Contato.AdicionarContato(contatos,teste2);
            Arquivo.SalvarArquivo(path,contatos);
            Contato.LerContatos(contatos);

                
            
           
           

          
            
            
           
        }
    }
}
