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

        public static void AdicionarContato(List<Contato> contatos,Contato saida)
        {
            try
            {
                contatos.Add(saida);
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"erro: {e.Message}");
            }
        }

       
           


        public static void RemoverContatos(List<Contato> contatos,string nome)
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
           foreach(Contato cont in contatos)
                {
                    Console.WriteLine($"nome:{cont.Nome},numero: {cont.Numero}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"erro:{e.Message}");
                
            }
            
        }

        
       
        

    }

}    

