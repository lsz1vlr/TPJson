using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSON.Model;
using JSON.Controller;

namespace JSON
{
    public partial class Form1 : Form
    {
        private ControllerCliente cc = new ControllerCliente();
        public Form1()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  void LimparCampos()
        {
            txNome.Clear();
            txEmail.Clear();
            txIdade.Clear();

        }
        private void AtualizarLista()
        {
            List<Cliente> clientes = cc.CarregarDados();
            list_clientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                list_clientes.Items.Add(cliente);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;
            string email = txEmail.Text;
            int idade = int.Parse(txIdade.Text);
            cc.CadastrarCliente(nome, email, idade);
            AtualizarLista();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (list_clientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente para atualizar!");
                return;
            }

            var clienteSelecionado = cc.clientes[list_clientes.SelectedIndex];

            clienteSelecionado.Nome = txNome.Text;
            clienteSelecionado.Email = txEmail.Text;
            clienteSelecionado.Idade = int.TryParse(txIdade.Text, out int idade) ? idade : 0;

            cc.SalvarDados();
            AtualizarLista();
            LimparCampos();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (list_clientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente para deletar!");
                return;
            }

            cc.clientes.RemoveAt(list_clientes.SelectedIndex);

            cc.SalvarDados();
            AtualizarLista();
            MessageBox.Show("Cliente deletado com sucesso!");
        }
    }
}
