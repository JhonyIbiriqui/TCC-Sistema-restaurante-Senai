﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurante
{
    public partial class FormIngrediente : Form
    {
        public int Id { get; set; }
        public string nome { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormIngrediente()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "" && txtNome.Text != null) && (txtTipo.Text != "" && txtTipo != null))
            {
                Ingrediente ingred = new Ingrediente();
                string adicional = "N";
                if (ckAdicional.CheckState == CheckState.Checked)
                {
                    adicional = "S";
                }
                ingred.Inserir(txtNome.Text, txtTipo.Text, adicional, txtDetalhes.Text);
                atualizaDGV();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "" && txtNome.Text != null) && (txtTipo.Text != "" && txtTipo != null))
            {
                Ingrediente ingred = new Ingrediente();
                string adicional = "N";
                if (ckAdicional.CheckState == CheckState.Checked)
                {
                    adicional = "S";
                }
                ingred.Atualizar(txtNome.Text, txtTipo.Text, adicional, txtDetalhes.Text, Id);
                atualizaDGV();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (sugestao sg = new sugestao("Deseja mesmo apagar o ingrediente: '" + nome + "' ?") { })
            {
                if (DialogResult.Yes == sg.ShowDialog())
                {
                    Ingrediente Ingred = new Ingrediente();
                    Ingred.Apagar(Id);
                    atualizaDGV();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDetalhes.Text = string.Empty;
            ckAdicional.Checked = false;
        }

        private void dgvIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvIngred.Rows[e.RowIndex];
                txtNome.Text = row.Cells[1].Value.ToString().Trim();
                txtTipo.Text = row.Cells[2].Value.ToString().Trim();
                if (row.Cells[3].Value.ToString().Trim() == "S")
                {
                    ckAdicional.Checked = true;
                }
                else
                {
                    ckAdicional.Checked = false;
                }
                txtDetalhes.Text = row.Cells[4].Value.ToString().Trim();
                Id = (int)row.Cells[0].Value;
                nome = row.Cells[1].Value.ToString().Trim();
            }
        }

        private void FormIngrediente_Load(object sender, EventArgs e)
        {
            atualizaDGV();
        }

        public void atualizaDGV()
        {
            Ingrediente ingred = new Ingrediente();
            List<Ingrediente> listaingred = ingred.listarIngred();
            dgvIngred.DataSource = listaingred;
            dgvIngred.Columns[0].Width = 54;
            dgvIngred.Columns[2].Width = 76;
            dgvIngred.Columns[3].Width = 65;
            txtNome.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDetalhes.Text = string.Empty;
            ckAdicional.Checked = false;
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            AutoCompleteStringCollection sugestaotipo = new AutoCompleteStringCollection();
            con.Open();
            string sql = "SELECT DISTINCT Tipo FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sugestaotipo.Add(dr["Tipo"].ToString().Trim());
            }
            txtTipo.AutoCompleteCustomSource = sugestaotipo;
            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}