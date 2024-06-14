using System;

using System.Text.Json;
namespace agenda_beta_.Entities
{
    internal class Contact
    {
        public string? Nome { get; set; }
        public string? Numero { get; set; }

        public Contact(string nome, string numero)
        {
            Nome = nome;
            Numero = numero;
        }

        
        public override string ToString()
        {
            return $"nome:{Nome}, numero:{Numero}";
        }


    }

}

