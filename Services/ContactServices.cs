using agenda_beta_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_beta_.Services
{
    internal class ContactServices
    {

        public static void AdicionarContato(List<Contact> contatos)
        {
            Console.Clear();
            Console.Write("nome:");
            string nome = Console.ReadLine()!;
            Contact? verificação = contatos.Find(x => x.Nome == nome);
            if (verificação != null)
            {
                Console.WriteLine("esse contato ja existe");

            }
            else
            {
                Console.Write("numero:");
                string numero = Console.ReadLine()!;
                Contact adicionado = new Contact(nome, numero);
                try
                {
                    contatos.Add(adicionado);
                    Arquivo.SalvarArquivo("contatos.json", contatos);
                    Console.WriteLine("contato adicionado com sucesso");

                }
                catch (Exception e)
                {
                    Console.WriteLine($"erro: {e.Message}");
                }
            }
        }


        public static void EditarContato(List<Contact> contatos)
        {
            Console.Clear();
            Console.WriteLine("digite o nome do contato que deseja editar");
            string nome = Console.ReadLine()!;

            Contact procurado = contatos.Find(x => x.Nome == nome)!;

            Console.WriteLine("1-editar nome\n2-editar numero");
            int escolha = int.Parse(Console.ReadLine()!);
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("digite um novo nome");
                    string novoNome = Console.ReadLine()!;
                    procurado.Nome = novoNome;
                    Arquivo.SalvarArquivo("contatos.json", contatos);
                    Console.WriteLine("contato editado com sucesso");
                    break;
                case 2:
                    Console.WriteLine("digite um novo numero");
                    string novoNumero = Console.ReadLine()!;
                    procurado.Numero = novoNumero;
                    Arquivo.SalvarArquivo("contatos.json", contatos);
                    Console.WriteLine("Contato editado com sucesso");
                    break;

            }

        }



        public static void RemoverContato(List<Contact> contatos)
        {
            Console.Clear();
            Console.WriteLine("digite o nome do contato que deseja deletar:");
            string nome = Console.ReadLine()!;
            Contact procurado = contatos.Find(x => x.Nome == nome)!;

            try
            {
                contatos.Remove(procurado);
                Arquivo.SalvarArquivo("contatos.json", contatos);
                Console.WriteLine("contato removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e);
            }


        }

        public static void LerContatos(List<Contact> contatos)
        {
            try
            {
                Console.Clear();
                if (!contatos.Any())
                {
                    Console.WriteLine("nenhum contato foi adicionado no momento");
                }
                else
                {
                    foreach (Contact cont in contatos)
                    {
                        Console.WriteLine(cont);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"erro:{e.Message}");

            }



        }

    }
}
