using System;

using System.Text.Json;
using agenda_beta_.Entities;


namespace agenda_beta_
{
    internal class Arquivo
    {


        public static void verificação(string path)
        {
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("[  ]");
                }
            }
        }

        public static void SalvarArquivo(string path, List<Contact> contatos)
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
