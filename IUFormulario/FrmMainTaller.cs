﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUFormulario
{
    public partial class FrmMainTaller : Form
    {
        //Variable global que podrá acceder a los métodos definidos en el formulario
        LogicaNegocio.Cajero _objCajero = new LogicaNegocio.Cajero();
        public FrmMainTaller()
        {
            InitializeComponent();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            //LogicaNegocio.Cajero objCajero = new LogicaNegocio.Cajero(20000);
            //LogicaNegocio.Cajero objCajero = new LogicaNegocio.Cajero();
            TxtConsulta.Text = _objCajero.DineroActual.ToString();
        }

        private void DividirCero() 
        {
            int cero = 0;
            decimal error = 8 / cero;
        }

        private void RetirarDinero()
        {
            //Recuperar el valor del cuadro de texto TxtRetiro
            string montoRetiro = TxtRetiro.Text;
            //Hacer una instancia de la clase Cajero
            //LogicaNegocio.Cajero objCajero = new LogicaNegocio.Cajero();
            //string mensajeRetornado = "";
            string mensajeRetornado = string.Empty;
            decimal valorRetornado = 0; //Para guardar lo que devuelva el método RetirarDinero
            valorRetornado = _objCajero.RetirarDinero(Convert.ToDecimal(montoRetiro), ref mensajeRetornado);
            //Mostrar en el cuadro de texto TxtConsulta lo que queda disponible
            TxtConsulta.Text = valorRetornado.ToString();
            TxtMensajeCajero.Text = mensajeRetornado;
        }

        private void BtnRetiro_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DividirCero();
                }
                catch (DivideByZeroException ex)
                {
                    TxtMensajeCajero.Text = ex.Message;
                }
                RetirarDinero();
                
            }
            catch (Exception ex)
            {
                TxtMensajeCajero.Text = ex.Message;
            }
        }
    }
}
