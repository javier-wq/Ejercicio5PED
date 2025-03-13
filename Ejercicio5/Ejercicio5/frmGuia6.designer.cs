namespace Ejercicio5
{
    partial class frmGuia6
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRecorrerArbol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoNum = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnBuscarNum = new System.Windows.Forms.Button();
            this.btnBorrarNum = new System.Windows.Forms.Button();
            this.btnInsertarAleatorio = new System.Windows.Forms.Button();
            this.btnEscribirArchivo = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.cmbTiposRecorrido = new System.Windows.Forms.ComboBox();
            this.lstRecorrido = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkResaltarNodos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecorrerArbol
            // 
            this.btnRecorrerArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrerArbol.Location = new System.Drawing.Point(28, 392);
            this.btnRecorrerArbol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecorrerArbol.Name = "btnRecorrerArbol";
            this.btnRecorrerArbol.Size = new System.Drawing.Size(111, 82);
            this.btnRecorrerArbol.TabIndex = 5;
            this.btnRecorrerArbol.Text = "Realizar Recorrido";
            this.btnRecorrerArbol.UseVisualStyleBackColor = true;
            this.btnRecorrerArbol.Click += new System.EventHandler(this.btnRecorrerArbol_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(321, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 896);
            this.panel1.TabIndex = 2;
            // 
            // btnNuevoNum
            // 
            this.btnNuevoNum.Location = new System.Drawing.Point(42, 158);
            this.btnNuevoNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoNum.Name = "btnNuevoNum";
            this.btnNuevoNum.Size = new System.Drawing.Size(208, 41);
            this.btnNuevoNum.TabIndex = 2;
            this.btnNuevoNum.Text = "Insertar valor";
            this.btnNuevoNum.UseVisualStyleBackColor = true;
            this.btnNuevoNum.Click += new System.EventHandler(this.btnNuevoNum_Click_1);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(166, 106);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(102, 35);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarNum
            // 
            this.btnBuscarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNum.Location = new System.Drawing.Point(42, 208);
            this.btnBuscarNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarNum.Name = "btnBuscarNum";
            this.btnBuscarNum.Size = new System.Drawing.Size(208, 35);
            this.btnBuscarNum.TabIndex = 3;
            this.btnBuscarNum.Text = "Buscar valor";
            this.btnBuscarNum.UseVisualStyleBackColor = true;
            this.btnBuscarNum.Click += new System.EventHandler(this.btnBuscarNum_Click_1);
            // 
            // btnBorrarNum
            // 
            this.btnBorrarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNum.Location = new System.Drawing.Point(42, 251);
            this.btnBorrarNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarNum.Name = "btnBorrarNum";
            this.btnBorrarNum.Size = new System.Drawing.Size(208, 38);
            this.btnBorrarNum.TabIndex = 4;
            this.btnBorrarNum.Text = "Eliminar valor";
            this.btnBorrarNum.UseVisualStyleBackColor = true;
            this.btnBorrarNum.Click += new System.EventHandler(this.btnBorrarNum_Click_1);
            // 
            // btnInsertarAleatorio
            // 
            this.btnInsertarAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarAleatorio.Location = new System.Drawing.Point(28, 45);
            this.btnInsertarAleatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertarAleatorio.Name = "btnInsertarAleatorio";
            this.btnInsertarAleatorio.Size = new System.Drawing.Size(228, 52);
            this.btnInsertarAleatorio.TabIndex = 8;
            this.btnInsertarAleatorio.Text = "Insertar numero aleatorio";
            this.btnInsertarAleatorio.UseVisualStyleBackColor = true;
            // 
            // btnEscribirArchivo
            // 
            this.btnEscribirArchivo.Location = new System.Drawing.Point(19, 122);
            this.btnEscribirArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEscribirArchivo.Name = "btnEscribirArchivo";
            this.btnEscribirArchivo.Size = new System.Drawing.Size(237, 58);
            this.btnEscribirArchivo.TabIndex = 11;
            this.btnEscribirArchivo.Text = "Salvar en Archivo:";
            this.btnEscribirArchivo.UseVisualStyleBackColor = true;
            this.btnEscribirArchivo.Click += new System.EventHandler(this.btnEscribirArchivo_Click);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(19, 46);
            this.btnAbrirArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(237, 58);
            this.btnAbrirArchivo.TabIndex = 12;
            this.btnAbrirArchivo.Text = "Recuperar de Archivo:";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // cmbTiposRecorrido
            // 
            this.cmbTiposRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiposRecorrido.FormattingEnabled = true;
            this.cmbTiposRecorrido.Items.AddRange(new object[] {
            "InOrden",
            "PostOrden",
            "PreOrden"});
            this.cmbTiposRecorrido.Location = new System.Drawing.Point(28, 334);
            this.cmbTiposRecorrido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTiposRecorrido.Name = "cmbTiposRecorrido";
            this.cmbTiposRecorrido.Size = new System.Drawing.Size(241, 33);
            this.cmbTiposRecorrido.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmbTiposRecorrido, "Seleccione tipo de recorrido de nodos del ABB");
            // 
            // lstRecorrido
            // 
            this.lstRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecorrido.FormattingEnabled = true;
            this.lstRecorrido.ItemHeight = 22;
            this.lstRecorrido.Location = new System.Drawing.Point(147, 392);
            this.lstRecorrido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRecorrido.Name = "lstRecorrido";
            this.lstRecorrido.Size = new System.Drawing.Size(122, 202);
            this.lstRecorrido.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.chkResaltarNodos);
            this.groupBox1.Controls.Add(this.lstRecorrido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTiposRecorrido);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.btnInsertarAleatorio);
            this.groupBox1.Controls.Add(this.btnNuevoNum);
            this.groupBox1.Controls.Add(this.btnRecorrerArbol);
            this.groupBox1.Controls.Add(this.btnBuscarNum);
            this.groupBox1.Controls.Add(this.btnBorrarNum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 691);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones a realizar:";
            // 
            // chkResaltarNodos
            // 
            this.chkResaltarNodos.AutoSize = true;
            this.chkResaltarNodos.Checked = true;
            this.chkResaltarNodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResaltarNodos.Location = new System.Drawing.Point(56, 626);
            this.chkResaltarNodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkResaltarNodos.Name = "chkResaltarNodos";
            this.chkResaltarNodos.Size = new System.Drawing.Size(174, 26);
            this.chkResaltarNodos.TabIndex = 19;
            this.chkResaltarNodos.Text = "Resaltar Nodos";
            this.chkResaltarNodos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor a operar:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnAbrirArchivo);
            this.groupBox2.Controls.Add(this.btnEscribirArchivo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 746);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(285, 222);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Almacenamiento del ABB";
            // 
            // frmGuia6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1542, 938);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGuia6";
            this.Text = "PED104: Simulador de un Arbol Binario de Busqueda (ABB)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRecorrerArbol;
    private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevoNum;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnBuscarNum;
        private System.Windows.Forms.Button btnBorrarNum;
        private System.Windows.Forms.Button btnInsertarAleatorio;
        private System.Windows.Forms.Button btnEscribirArchivo;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.ComboBox cmbTiposRecorrido;
        private System.Windows.Forms.ListBox lstRecorrido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkResaltarNodos;
    }
}

