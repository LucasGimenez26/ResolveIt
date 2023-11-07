namespace ResolveIt
{
    partial class Calculadora
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
            this.components = new System.ComponentModel.Container();
            this.txtR = new System.Windows.Forms.TextBox();
            this.btCarita = new System.Windows.Forms.Button();
            this.btDivid = new System.Windows.Forms.Button();
            this.btSumar = new System.Windows.Forms.Button();
            this.btRestar = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btDelAll = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.btElev = new System.Windows.Forms.Button();
            this.btDel1 = new System.Windows.Forms.Button();
            this.calculadoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resolveItBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.calculadoraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolveItBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(12, 12);
            this.txtR.MaxLength = 3;
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(243, 30);
            this.txtR.TabIndex = 55;
            this.txtR.Text = "0";
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btCarita
            // 
            this.btCarita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btCarita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarita.Location = new System.Drawing.Point(208, 153);
            this.btCarita.Name = "btCarita";
            this.btCarita.Size = new System.Drawing.Size(41, 86);
            this.btCarita.TabIndex = 54;
            this.btCarita.Text = ":)";
            this.btCarita.UseVisualStyleBackColor = false;
            // 
            // btDivid
            // 
            this.btDivid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btDivid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivid.Location = new System.Drawing.Point(161, 61);
            this.btDivid.Name = "btDivid";
            this.btDivid.Size = new System.Drawing.Size(41, 40);
            this.btDivid.TabIndex = 53;
            this.btDivid.Tag = "/";
            this.btDivid.Text = "/";
            this.btDivid.UseVisualStyleBackColor = false;
            this.btDivid.Click += new System.EventHandler(this.clickOperador);
            // 
            // btSumar
            // 
            this.btSumar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSumar.Location = new System.Drawing.Point(161, 199);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(41, 40);
            this.btSumar.TabIndex = 52;
            this.btSumar.Tag = "+";
            this.btSumar.Text = "+";
            this.btSumar.UseVisualStyleBackColor = false;
            this.btSumar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btRestar
            // 
            this.btRestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestar.Location = new System.Drawing.Point(161, 153);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(41, 40);
            this.btRestar.TabIndex = 51;
            this.btRestar.Tag = "-";
            this.btRestar.Text = "-";
            this.btRestar.UseVisualStyleBackColor = false;
            this.btRestar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btMulti
            // 
            this.btMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMulti.Location = new System.Drawing.Point(161, 107);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(41, 40);
            this.btMulti.TabIndex = 50;
            this.btMulti.Tag = "x";
            this.btMulti.Text = "x";
            this.btMulti.UseVisualStyleBackColor = false;
            this.btMulti.Click += new System.EventHandler(this.clickOperador);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.Silver;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(19, 245);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(136, 40);
            this.bt0.TabIndex = 49;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Silver;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(20, 107);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(41, 40);
            this.bt1.TabIndex = 48;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Silver;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(67, 153);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(41, 40);
            this.bt5.TabIndex = 47;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Silver;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(67, 107);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(41, 40);
            this.bt2.TabIndex = 46;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.Silver;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(114, 153);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(41, 40);
            this.bt6.TabIndex = 45;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Silver;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(114, 107);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(41, 40);
            this.bt3.TabIndex = 44;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.Silver;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(20, 153);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(41, 40);
            this.bt4.TabIndex = 43;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.Silver;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(20, 199);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(41, 40);
            this.bt7.TabIndex = 42;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDel.Location = new System.Drawing.Point(67, 61);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(41, 40);
            this.btDel.TabIndex = 41;
            this.btDel.Text = "C";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.Silver;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(67, 199);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(41, 40);
            this.bt8.TabIndex = 40;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.Silver;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(114, 199);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(41, 40);
            this.bt9.TabIndex = 39;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btDelAll
            // 
            this.btDelAll.BackColor = System.Drawing.Color.Red;
            this.btDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btDelAll.Location = new System.Drawing.Point(20, 61);
            this.btDelAll.Name = "btDelAll";
            this.btDelAll.Size = new System.Drawing.Size(41, 40);
            this.btDelAll.TabIndex = 38;
            this.btDelAll.Text = "CE";
            this.btDelAll.UseVisualStyleBackColor = false;
            this.btDelAll.Click += new System.EventHandler(this.btDelAall_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(161, 245);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(88, 40);
            this.btIgual.TabIndex = 56;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btRaiz
            // 
            this.btRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRaiz.Location = new System.Drawing.Point(208, 107);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(41, 40);
            this.btRaiz.TabIndex = 57;
            this.btRaiz.Tag = "√";
            this.btRaiz.Text = "√";
            this.btRaiz.UseVisualStyleBackColor = false;
            this.btRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btElev
            // 
            this.btElev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btElev.Location = new System.Drawing.Point(208, 61);
            this.btElev.Name = "btElev";
            this.btElev.Size = new System.Drawing.Size(41, 40);
            this.btElev.TabIndex = 58;
            this.btElev.Tag = "²";
            this.btElev.Text = "x²";
            this.btElev.UseVisualStyleBackColor = false;
            this.btElev.Click += new System.EventHandler(this.clickOperador);
            // 
            // btDel1
            // 
            this.btDel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btDel1.Location = new System.Drawing.Point(114, 61);
            this.btDel1.Name = "btDel1";
            this.btDel1.Size = new System.Drawing.Size(41, 40);
            this.btDel1.TabIndex = 59;
            this.btDel1.Text = "DEL";
            this.btDel1.UseVisualStyleBackColor = false;
            this.btDel1.Click += new System.EventHandler(this.btDel1_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(267, 12);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(130, 273);
            this.dg.TabIndex = 60;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(409, 302);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btDel1);
            this.Controls.Add(this.btElev);
            this.Controls.Add(this.btRaiz);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btCarita);
            this.Controls.Add(this.btDivid);
            this.Controls.Add(this.btSumar);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btDelAll);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calculadoraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolveItBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btCarita;
        private System.Windows.Forms.Button btDivid;
        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Button btRestar;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btDelAll;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button btElev;
        private System.Windows.Forms.Button btDel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoScrollDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoSizeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoSizeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoValidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formBorderStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helpButtonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMdiContainerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn keyPreviewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maximizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn minimizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rightToLeftLayoutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showInTaskbarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showIconDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGripStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn topMostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transparencyKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMarginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMinSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource resolveItBindingSource;
        private System.Windows.Forms.BindingSource calculadoraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.BindingSource calculadoraBindingSource1;
        private System.Windows.Forms.DataGridView dg;
    }
}