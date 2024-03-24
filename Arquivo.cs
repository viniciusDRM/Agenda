using System;

using System.Text.Json;


namespace agenda_beta_
{
    internal class Arquivo
    {

        public static void SalvarArquivo(string path, List<Contato> contatos)
        {
            try
            {
                string json = JsonSerializer.Serialize(contatos);
                File.WriteAllText(path, json);

            }
            catch (Exception e)
            {
                Console.WriteLine($"erro: {e}");
            }
        }
    }
}
