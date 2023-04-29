﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
            TreeNode parentNode = treeView2.Nodes.Add("Legista");
            TreeNode childNode = parentNode.Nodes.Add("Cadastrar");
            TreeNode childNode1 = parentNode.Nodes.Add("Remover");
            TreeNode childNode2 = parentNode.Nodes.Add("Alterar");
            TreeNode parentNode1 = treeView2.Nodes.Add("Assistente");
            TreeNode childNode3 = parentNode1.Nodes.Add("Cadastrar");
            TreeNode childNode4 = parentNode1.Nodes.Add("Remover");
            TreeNode childNode5 = parentNode1.Nodes.Add("Alterar");
            TreeNode parentNode2 = treeView2.Nodes.Add("Estoque");
            TreeNode childNode6 = parentNode2.Nodes.Add("Cadastrar");
            TreeNode childNode7 = parentNode2.Nodes.Add("Adicionar");
            TreeNode parentNode3 = treeView2.Nodes.Add("Fornecedor");
            TreeNode childNode8 = parentNode3.Nodes.Add("Cadastrar");
            TreeNode childNode9 = parentNode3.Nodes.Add("Remover");
            TreeNode childNode10 = parentNode3.Nodes.Add("Alterar");
            TreeNode parentNode4 = treeView2.Nodes.Add("Dados");
            TreeNode childNode11 = parentNode4.Nodes.Add("Legista");
            TreeNode childNode12 = parentNode4.Nodes.Add("Assistente");
            TreeNode childNode13 = parentNode4.Nodes.Add("Estoque");
            TreeNode childNode14 = parentNode4.Nodes.Add("Fornecedor");

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
                

            
        }
      

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Legista")
            {

                this.Hide();

                CadastrarL novaTela = new CadastrarL();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Remover" && e.Node.Parent.Text == "Legista")
                {
                this.Hide();

                RemoverL novaTela = new RemoverL();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Alterar" && e.Node.Parent.Text == "Legista")
            {
                this.Hide();

                AlterarL novaTela = new AlterarL();
                novaTela.ShowDialog();
            }
           else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Assistente")
            {
                this.Hide();

                CadastrarA novaTela = new CadastrarA();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Remover" && e.Node.Parent.Text == "Assistente")
            {
                this.Hide();

                RemoverA novaTela = new RemoverA();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Alterar" && e.Node.Parent.Text == "Assistente")
            {
                this.Hide();

                AlterarA novaTela = new AlterarA();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Estoque")
            {
                this.Hide();

                CadastrarE novaTela = new CadastrarE();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Adicionar" && e.Node.Parent.Text == "Estoque")
            {
                this.Hide();

                AdicionarE novaTela = new AdicionarE();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Fornecedor")
            {
                this.Hide();

                CadastrarF novaTela = new CadastrarF();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Remover" && e.Node.Parent.Text == "Fornecedor")
            {
                this.Hide();

                RemoverF novaTela = new RemoverF();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Alterar" && e.Node.Parent.Text == "Fornecedor")
            {
                this.Hide();

                AlterarF novaTela = new AlterarF();
                novaTela.ShowDialog();
            }
            if (e.Node.Text == "Legista" && e.Node.Parent != null && e.Node.Parent.Text == "Dados")
            {
                this.Hide();

                DadosL novaTela = new DadosL();
                novaTela.ShowDialog();
            }
            if (e.Node.Text == "Assistente" && e.Node.Parent != null && e.Node.Parent.Text == "Dados")
            {
                this.Hide();

                DadosA novaTela = new DadosA();
                novaTela.ShowDialog();
            }
             if (e.Node.Text == "Estoque" && e.Node.Parent != null && e.Node.Parent.Text == "Dados")
            {
                this.Hide();

                DadosE novaTela = new DadosE();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Fornecedor" && e.Node.Parent.Text == "Dados")
            {
                this.Hide();

                DadosF novaTela = new DadosF();
                novaTela.ShowDialog();
            }
        }
    }
}