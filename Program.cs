using System.IO;
using System.Text.Json;
namespace agenda_beta_
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string path = "contatos.json";
			
			if(!File.Exists(path))
			{
				
				using(StreamWriter sw = File.CreateText(path))
				{
					sw.Write("[  ]");
				}
			}
			
        string lista = File.ReadAllText(path);
            
          List<Contato> contatos = JsonSerializer.Deserialize<List<Contato>>(lista);
			Console.WriteLine("bem vindo a sua agenda\n");
			while(true)
			{
			
			Console.Write("1-ler contatos\n2-adicionar contato\n3- editar contato\n4-excluir contato\n5- sair do programa\n");
			int escolha = int.Parse(Console.ReadLine());
			switch(escolha)
			{
			case 1:
				Contato.LerContatos(contatos);
			break;
			case 2:
				Contato.AdicionarContato(contatos);
			break;			
			case 3:
			Contato.EditarContato(contatos);
			break;
			case 4:
			Contato.RemoverContato(contatos);
			break;
			case 5:
			System.Environment.Exit(1);
			
			break;
				
				
				
			}

			}
                
            
           
           

          
            
            
           
        }
    }
}
