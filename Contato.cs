using System;

using System.Text.Json;
namespace agenda_beta_
{
    internal class Contato
    {
       
        public string? Nome { get; set; }
        public string? Numero { get; set; }

   public Contato(string nome,string numero)
        {
            this.Nome = nome;
            this.Numero = numero;
        }

        public static void AdicionarContato(List<Contato> contatos)
        {
			
			Console.Write("nome: ");
			string nome = Console.ReadLine();
			Console.Write("numero: ");
			string numero = Console.ReadLine();
			Contato adicionado = new Contato(nome,numero);
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

       
           


        public static void RemoverContato(List<Contato> contatos,string nome)
        {
            Contato procurado = contatos.Find(x => x.Nome == nome);

            try
            {
                contatos.Remove(procurado);
                Console.WriteLine("contato removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e);
            }


        }

        public static void  LerContatos(List<Contato> contatos)
        {
            try
            {
				Console.Clear();
				if(!contatos.Any())
				{
					Console.WriteLine("nenhum contato foi adicionado no momento");
				}
				else
				{
           foreach(Contato cont in contatos)
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

        
       public override string ToString()
	   {
		   return $"nome:{Nome}, numero:{Numero}";
	   }
        

    }

}    

