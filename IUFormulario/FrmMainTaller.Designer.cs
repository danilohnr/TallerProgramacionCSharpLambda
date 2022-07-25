namespace IUFormulario
{
    partial class FrmMainTaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnRetiro = new System.Windows.Forms.Button();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.TxtRetiro = new System.Windows.Forms.TextBox();
            this.TxtMensajeCajero = new System.Windows.Forms.TextBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.TxtListaArray = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.GrbPractica = new System.Windows.Forms.GroupBox();
            this.GrbPracticaGenericos = new System.Windows.Forms.GroupBox();
            this.BtnGenerico = new System.Windows.Forms.Button();
            this.BtnObjeto = new System.Windows.Forms.Button();
            this.TxtListaPersonas = new System.Windows.Forms.TextBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.LblApellido2 = new System.Windows.Forms.Label();
            this.LblApellido1 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.BtnLinkedList = new System.Windows.Forms.Button();
            this.GrbPractica.SuspendLayout();
            this.GrbPracticaGenericos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(102, 52);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta.TabIndex = 0;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnRetiro
            // 
            this.BtnRetiro.Location = new System.Drawing.Point(255, 20);
            this.BtnRetiro.Name = "BtnRetiro";
            this.BtnRetiro.Size = new System.Drawing.Size(75, 23);
            this.BtnRetiro.TabIndex = 1;
            this.BtnRetiro.Text = "Retiro";
            this.BtnRetiro.UseVisualStyleBackColor = true;
            this.BtnRetiro.Click += new System.EventHandler(this.BtnRetiro_Click);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(219, 52);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(100, 23);
            this.TxtConsulta.TabIndex = 2;
            // 
            // TxtRetiro
            // 
            this.TxtRetiro.Location = new System.Drawing.Point(336, 20);
            this.TxtRetiro.Name = "TxtRetiro";
            this.TxtRetiro.Size = new System.Drawing.Size(100, 23);
            this.TxtRetiro.TabIndex = 3;
            // 
            // TxtMensajeCajero
            // 
            this.TxtMensajeCajero.Location = new System.Drawing.Point(102, 100);
            this.TxtMensajeCajero.Multiline = true;
            this.TxtMensajeCajero.Name = "TxtMensajeCajero";
            this.TxtMensajeCajero.Size = new System.Drawing.Size(345, 69);
            this.TxtMensajeCajero.TabIndex = 4;
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(102, 188);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(75, 23);
            this.BtnArray.TabIndex = 5;
            this.BtnArray.Text = "Lista Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // TxtListaArray
            // 
            this.TxtListaArray.Location = new System.Drawing.Point(215, 189);
            this.TxtListaArray.Name = "TxtListaArray";
            this.TxtListaArray.Size = new System.Drawing.Size(232, 23);
            this.TxtListaArray.TabIndex = 6;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(102, 238);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(75, 23);
            this.BtnList.TabIndex = 7;
            this.BtnList.Text = "Lista List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // TxtList
            // 
            this.TxtList.Location = new System.Drawing.Point(215, 238);
            this.TxtList.Name = "TxtList";
            this.TxtList.Size = new System.Drawing.Size(232, 23);
            this.TxtList.TabIndex = 8;
            // 
            // GrbPractica
            // 
            this.GrbPractica.Controls.Add(this.GrbPracticaGenericos);
            this.GrbPractica.Controls.Add(this.TxtListaPersonas);
            this.GrbPractica.Controls.Add(this.TxtApellido2);
            this.GrbPractica.Controls.Add(this.TxtApellido1);
            this.GrbPractica.Controls.Add(this.TxtNombre);
            this.GrbPractica.Controls.Add(this.TxtIdentificacion);
            this.GrbPractica.Controls.Add(this.LblApellido2);
            this.GrbPractica.Controls.Add(this.TxtRetiro);
            this.GrbPractica.Controls.Add(this.LblApellido1);
            this.GrbPractica.Controls.Add(this.LblNombre);
            this.GrbPractica.Controls.Add(this.BtnRetiro);
            this.GrbPractica.Controls.Add(this.LblIdentificacion);
            this.GrbPractica.Location = new System.Drawing.Point(98, 285);
            this.GrbPractica.Name = "GrbPractica";
            this.GrbPractica.Size = new System.Drawing.Size(690, 229);
            this.GrbPractica.TabIndex = 9;
            this.GrbPractica.TabStop = false;
            this.GrbPractica.Text = "Practica 4";
            // 
            // GrbPracticaGenericos
            // 
            this.GrbPracticaGenericos.Controls.Add(this.BtnGenerico);
            this.GrbPracticaGenericos.Controls.Add(this.BtnObjeto);
            this.GrbPracticaGenericos.Location = new System.Drawing.Point(442, 20);
            this.GrbPracticaGenericos.Name = "GrbPracticaGenericos";
            this.GrbPracticaGenericos.Size = new System.Drawing.Size(228, 100);
            this.GrbPracticaGenericos.TabIndex = 9;
            this.GrbPracticaGenericos.TabStop = false;
            this.GrbPracticaGenericos.Text = "Practica 5";
            // 
            // BtnGenerico
            // 
            this.BtnGenerico.Location = new System.Drawing.Point(13, 51);
            this.BtnGenerico.Name = "BtnGenerico";
            this.BtnGenerico.Size = new System.Drawing.Size(127, 23);
            this.BtnGenerico.TabIndex = 1;
            this.BtnGenerico.Text = "Ejemplo Generico";
            this.BtnGenerico.UseVisualStyleBackColor = true;
            this.BtnGenerico.Click += new System.EventHandler(this.BtnGenerico_Click);
            // 
            // BtnObjeto
            // 
            this.BtnObjeto.Location = new System.Drawing.Point(13, 22);
            this.BtnObjeto.Name = "BtnObjeto";
            this.BtnObjeto.Size = new System.Drawing.Size(127, 23);
            this.BtnObjeto.TabIndex = 0;
            this.BtnObjeto.Text = "Ejemplo Object";
            this.BtnObjeto.UseVisualStyleBackColor = true;
            this.BtnObjeto.Click += new System.EventHandler(this.BtnObjeto_Click);
            // 
            // TxtListaPersonas
            // 
            this.TxtListaPersonas.Location = new System.Drawing.Point(27, 126);
            this.TxtListaPersonas.Multiline = true;
            this.TxtListaPersonas.Name = "TxtListaPersonas";
            this.TxtListaPersonas.Size = new System.Drawing.Size(643, 84);
            this.TxtListaPersonas.TabIndex = 8;
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Location = new System.Drawing.Point(140, 92);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(100, 23);
            this.TxtApellido2.TabIndex = 7;
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Location = new System.Drawing.Point(140, 68);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(100, 23);
            this.TxtApellido1.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(140, 44);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(140, 20);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 23);
            this.TxtIdentificacion.TabIndex = 4;
            // 
            // LblApellido2
            // 
            this.LblApellido2.AutoSize = true;
            this.LblApellido2.Location = new System.Drawing.Point(23, 92);
            this.LblApellido2.Name = "LblApellido2";
            this.LblApellido2.Size = new System.Drawing.Size(102, 15);
            this.LblApellido2.TabIndex = 3;
            this.LblApellido2.Text = "Segundo apellido:";
            // 
            // LblApellido1
            // 
            this.LblApellido1.AutoSize = true;
            this.LblApellido1.Location = new System.Drawing.Point(35, 68);
            this.LblApellido1.Name = "LblApellido1";
            this.LblApellido1.Size = new System.Drawing.Size(90, 15);
            this.LblApellido1.TabIndex = 2;
            this.LblApellido1.Text = "Primer apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(71, 44);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Location = new System.Drawing.Point(43, 20);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(82, 15);
            this.LblIdentificacion.TabIndex = 0;
            this.LblIdentificacion.Text = "Identificación:";
            // 
            // BtnLinkedList
            // 
            this.BtnLinkedList.Location = new System.Drawing.Point(474, 189);
            this.BtnLinkedList.Name = "BtnLinkedList";
            this.BtnLinkedList.Size = new System.Drawing.Size(75, 23);
            this.BtnLinkedList.TabIndex = 10;
            this.BtnLinkedList.Text = "LinkedList";
            this.BtnLinkedList.UseVisualStyleBackColor = true;
            // 
            // FrmMainTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.BtnLinkedList);
            this.Controls.Add(this.GrbPractica);
            this.Controls.Add(this.TxtList);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtListaArray);
            this.Controls.Add(this.BtnArray);
            this.Controls.Add(this.TxtMensajeCajero);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.BtnConsulta);
            this.Name = "FrmMainTaller";
            this.Text = "Taller";
            this.GrbPractica.ResumeLayout(false);
            this.GrbPractica.PerformLayout();
            this.GrbPracticaGenericos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnRetiro;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.TextBox TxtRetiro;
        private System.Windows.Forms.TextBox TxtMensajeCajero;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.TextBox TxtListaArray;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.TextBox TxtList;
        private System.Windows.Forms.GroupBox GrbPractica;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label LblApellido2;
        private System.Windows.Forms.Label LblApellido1;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.TextBox TxtListaPersonas;
        private System.Windows.Forms.GroupBox GrbPracticaGenericos;
        private System.Windows.Forms.Button BtnGenerico;
        private System.Windows.Forms.Button BtnObjeto;
        private System.Windows.Forms.Button BtnLinkedList;
    }
}