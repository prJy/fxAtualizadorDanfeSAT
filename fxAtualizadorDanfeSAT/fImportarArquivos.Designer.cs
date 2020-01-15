namespace fxAtualizadorDanfeSAT
{
    partial class fImportarArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportarArquivos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Arquivos = new System.Windows.Forms.Label();
            this.listaArquivos = new System.Windows.Forms.CheckedListBox();
            this.btnCarregarArquivos = new System.Windows.Forms.Button();
            this.txtCaminhoArquivos = new System.Windows.Forms.TextBox();
            this.btnGerarScript = new System.Windows.Forms.Button();
            this.resultadoTxt = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 345);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGerarScript);
            this.tabPage1.Controls.Add(this.Arquivos);
            this.tabPage1.Controls.Add(this.listaArquivos);
            this.tabPage1.Controls.Add(this.btnCarregarArquivos);
            this.tabPage1.Controls.Add(this.txtCaminhoArquivos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuração";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultadoTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Arquivos
            // 
            this.Arquivos.AutoSize = true;
            this.Arquivos.Location = new System.Drawing.Point(15, 50);
            this.Arquivos.Name = "Arquivos";
            this.Arquivos.Size = new System.Drawing.Size(48, 13);
            this.Arquivos.TabIndex = 7;
            this.Arquivos.Text = "Arquivos";
            // 
            // listaArquivos
            // 
            this.listaArquivos.FormattingEnabled = true;
            this.listaArquivos.Location = new System.Drawing.Point(11, 67);
            this.listaArquivos.Name = "listaArquivos";
            this.listaArquivos.Size = new System.Drawing.Size(499, 214);
            this.listaArquivos.TabIndex = 6;
            // 
            // btnCarregarArquivos
            // 
            this.btnCarregarArquivos.Location = new System.Drawing.Point(384, 15);
            this.btnCarregarArquivos.Name = "btnCarregarArquivos";
            this.btnCarregarArquivos.Size = new System.Drawing.Size(126, 23);
            this.btnCarregarArquivos.TabIndex = 5;
            this.btnCarregarArquivos.Text = "Selecionar Diretório";
            this.btnCarregarArquivos.UseVisualStyleBackColor = true;
            this.btnCarregarArquivos.Click += new System.EventHandler(this.btnCarregarArquivos_Click);
            // 
            // txtCaminhoArquivos
            // 
            this.txtCaminhoArquivos.Location = new System.Drawing.Point(11, 17);
            this.txtCaminhoArquivos.Name = "txtCaminhoArquivos";
            this.txtCaminhoArquivos.Size = new System.Drawing.Size(367, 20);
            this.txtCaminhoArquivos.TabIndex = 4;
            // 
            // btnGerarScript
            // 
            this.btnGerarScript.Location = new System.Drawing.Point(413, 290);
            this.btnGerarScript.Name = "btnGerarScript";
            this.btnGerarScript.Size = new System.Drawing.Size(97, 23);
            this.btnGerarScript.TabIndex = 8;
            this.btnGerarScript.Text = "Gerar Script";
            this.btnGerarScript.UseVisualStyleBackColor = true;
            this.btnGerarScript.Click += new System.EventHandler(this.btnGerarScript_Click);
            // 
            // resultadoTxt
            // 
            this.resultadoTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoTxt.Location = new System.Drawing.Point(3, 3);
            this.resultadoTxt.Name = "resultadoTxt";
            this.resultadoTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.resultadoTxt.Size = new System.Drawing.Size(517, 313);
            this.resultadoTxt.TabIndex = 0;
            this.resultadoTxt.Text = "";
            // 
            // fImportarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 345);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fImportarArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizador De Arquivos do SAT (Correção campo DANFE)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGerarScript;
        private System.Windows.Forms.Label Arquivos;
        private System.Windows.Forms.CheckedListBox listaArquivos;
        private System.Windows.Forms.Button btnCarregarArquivos;
        private System.Windows.Forms.TextBox txtCaminhoArquivos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox resultadoTxt;
    }
}

