using agenda_beta_.Entities;
using System.Text.Json;
using agenda_beta_.Services;
namespace agenda_beta_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "contatos.json";

            Arquivo.verificação(path);
            string lista = File.ReadAllText(path);

            List<Contact> contatos = JsonSerializer.Deserialize<List<Contact>>(lista)!;
            Console.WriteLine("bem vindo a sua agenda\n");
            while (true)
            {

             Console.Write("1-ler contatos\n2-adicionar contato\n3- editar contato\n4-excluir contato\n5- sair do programa\n");
                int escolha = int.Parse(Console.ReadLine()!);
                switch (escolha)
                {
                    case 1:
                        ContactServices.LerContatos(contatos);
                        break;
                    case 2:
                        ContactServices.AdicionarContato(contatos);
                        break;
                    case 3:
                        ContactServices.EditarContato(contatos);
                        break;
                    case 4:
                        ContactServices.RemoverContato(contatos);
                        break;
                    case 5:
                        System.Environment.Exit(1);
                        break;



                }

            }









        }
    }
}
