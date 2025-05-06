using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSON.Model;
using System.Text.Json;
using System.IO;

namespace JSON.Controller
{
    internal class ControllerCliente
    {
        private string arquivoCaminho = "clientes.json";
        public List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> CarregarDados()
        {
            if (File.Exists(arquivoCaminho))
            {
                string json = File.ReadAllText(arquivoCaminho);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(json) ?? new List<Cliente>();

            }
            return clientes;
        }

        public void CadastrarCliente(string nome, string email, int idade)
        {
            int novoId = clientes.Count > 0 ? clientes[clientes.Count - 1].Id + 1 : 0;
            clientes.Add(new Cliente
            {
                Id = novoId,
                Nome = nome,
                Email = email,
                Idade = idade
            });
            SalvarDados();
        }

        public void SalvarDados()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(arquivoCaminho, json);
        }
    }
}
