using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back;

namespace ResolveIt
{
    public partial class Calculadora : Form
    {
        Resultados ListaResultados { get; set; } = new Resultados();

        double num1 = 0, num2 = 0;
        char operador;

        public Calculadora()
        {
            InitializeComponent();
            ListaResultados.leerArchivo();
            dg.DataSource = ListaResultados.ListaRes;
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            num1 = Convert.ToDouble(txtR.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                num1 = Math.Pow(num1, 2);
                txtR.Text = num1.ToString();
            }

            else if (operador == '√')
            {
                num1 = Math.Sqrt (num1);
                txtR.Text = num1.ToString();
            }

            else
            {
                txtR.Text = "0";
            }

        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            Resultado res = new Resultado();

            num2 = Convert.ToDouble(txtR.Text);

            if (operador == '+')
            {
                txtR.Text = (num1 + num2).ToString();
                res.Agregar(txtR.Text);
                ListaResultados.InsertRes(res);
            }
            else if (operador == '-')
            {
                txtR.Text = (num1 - num2).ToString();
                res.Agregar(txtR.Text);
                ListaResultados.InsertRes(res);
            }
            else if (operador == 'x')
            {
                txtR.Text = (num1 * num2).ToString();
                res.Agregar(txtR.Text);
                ListaResultados.InsertRes(res);
            }
            else if (operador == '/')
            {
                txtR.Text = (num1 / num2).ToString();
                res.Agregar(txtR.Text);
                ListaResultados.InsertRes(res);
            }
            else if (operador == '²')
            {
                num1 = Math.Pow(num1, 2);
                txtR.Text = num1.ToString();
                res.Agregar(txtR.Text);
                ListaResultados.InsertRes(res);
            }
            else if (operador == '√')
            {
                num1 = Math.Sqrt(num1);
                txtR.Text = num1.ToString();
                res.Agregar(txtR.Text);
                ListaResultados.InsertRes(res);
            }

            txtR.Text = "0";
        }


        private void btDelAall_Click(object sender, EventArgs e)
        {
            txtR.Text = "0";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txtR.Text = "0";
        }

        private void btDel1_Click(object sender, EventArgs e)
        {
            if (txtR.Text.Length > 1)
            {
                txtR.Text = txtR.Text.Substring(0, txtR.Text.Length - 1);
            }
            else
            {
                txtR.Text = "0";
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtR.Text == "0")
                txtR.Text = "";

            txtR.Text += boton.Text;
        }
    }
}
