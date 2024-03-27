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
			Console.Clear();
			Console.Write("nome:");
			string nome = Console.ReadLine();
			Contato? verificação = contatos.Find(x => x.Nome == nome);
			if(verificação != null)
			{
				Console.WriteLine("esse contato ja existe");
				
			}
			else{
			Console.Write("numero:");
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
        }
        

		public static void EditarContato(List<Contato> contatos)
		{
			Console.Clear();
			Console.WriteLine("digite o nome do contato que deseja editar");
			string nome = Console.ReadLine();
			
			Contato procurado = contatos.Find(x => x.Nome == nome);
			
			Console.WriteLine("1-editar nome\n2-editar numero");
			int escolha = int.Parse(Console.ReadLine());
			switch(escolha)
			{
			case 1:
			Console.WriteLine("digite um novo nome");
			string novoNome = Console.ReadLine();
			procurado.Nome = novoNome;
			Arquivo.SalvarArquivo("contatos.json",contatos);
			Console.WriteLine("contato editado com sucesso");
			break;
			case 2:
			Console.WriteLine("digite um novo numero");
			string novoNumero = Console.ReadLine();
			procurado.Numero = novoNumero;
			Arquivo.SalvarArquivo("contatos.json",contatos);
			Console.WriteLine("Contato editado com sucesso");
			break;
				
			}
			
		}
		

			
        public static void RemoverContato(List<Contato> contatos)
        {
			Console.Clear();
			Console.WriteLine("digite o nome do contato que deseja deletar:");
			string nome = Console.ReadLine();
            Contato procurado = contatos.Find(x => x.Nome == nome);

            try
            {
                contatos.Remove(procurado);
				Arquivo.SalvarArquivo("contatos.json",contatos);
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

