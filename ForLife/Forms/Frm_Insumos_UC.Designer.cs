namespace ForLife.Forms
{
    partial class Frm_Insumos_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tbtn_Adicionar = new System.Windows.Forms.ToolStripButton();
            this.tBtn_Editar = new System.Windows.Forms.ToolStripButton();
            this.tBtn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tBtn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tbtn_Pesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tbtn_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSUMOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tbtn_Adicionar,
            this.tBtn_Editar,
            this.tBtn_Salvar,
            this.toolStripSeparator1,
            this.tBtn_Excluir,
            this.toolStripSeparator2,
            this.Tbtn_Pesquisar,
            this.toolStripSeparator3,
            this.Tbtn_Cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(666, 56);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tbtn_Adicionar
            // 
            this.Tbtn_Adicionar.Image = global::ForLife.Properties.Resources.Adicionar;
            this.Tbtn_Adicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbtn_Adicionar.Name = "Tbtn_Adicionar";
            this.Tbtn_Adicionar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Tbtn_Adicionar.Size = new System.Drawing.Size(107, 30);
            this.Tbtn_Adicionar.Text = "Adicionar";
            this.Tbtn_Adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tbtn_Adicionar.ToolTipText = "Adicionar";
            // 
            // tBtn_Editar
            // 
            this.tBtn_Editar.Image = global::ForLife.Properties.Resources.Editar;
            this.tBtn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_Editar.Name = "tBtn_Editar";
            this.tBtn_Editar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tBtn_Editar.Size = new System.Drawing.Size(82, 30);
            this.tBtn_Editar.Text = "Editar";
            this.tBtn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tBtn_Editar.ToolTipText = "Editar";
            // 
            // tBtn_Salvar
            // 
            this.tBtn_Salvar.Image = global::ForLife.Properties.Resources.Salvar;
            this.tBtn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tBtn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_Salvar.Name = "tBtn_Salvar";
            this.tBtn_Salvar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tBtn_Salvar.Size = new System.Drawing.Size(83, 30);
            this.tBtn_Salvar.Text = "Salvar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tBtn_Excluir
            // 
            this.tBtn_Excluir.Image = global::ForLife.Properties.Resources.Apagar;
            this.tBtn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tBtn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_Excluir.Name = "tBtn_Excluir";
            this.tBtn_Excluir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tBtn_Excluir.Size = new System.Drawing.Size(86, 30);
            this.tBtn_Excluir.Text = "Excluir";
            this.tBtn_Excluir.ToolTipText = "Excluir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // Tbtn_Pesquisar
            // 
            this.Tbtn_Pesquisar.Image = global::ForLife.Properties.Resources.Pesquisar;
            this.Tbtn_Pesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbtn_Pesquisar.Name = "Tbtn_Pesquisar";
            this.Tbtn_Pesquisar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Tbtn_Pesquisar.Size = new System.Drawing.Size(114, 30);
            this.Tbtn_Pesquisar.Text = "Pesquisar";
            this.Tbtn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // Tbtn_Cancelar
            // 
            this.Tbtn_Cancelar.Image = global::ForLife.Properties.Resources.Excluir;
            this.Tbtn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tbtn_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbtn_Cancelar.Name = "Tbtn_Cancelar";
            this.Tbtn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Tbtn_Cancelar.Size = new System.Drawing.Size(100, 30);
            this.Tbtn_Cancelar.Text = "Cancelar";
            this.Tbtn_Cancelar.ToolTipText = "Cancelar";
            // 
            // Frm_Insumos_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Insumos_UC";
            this.Size = new System.Drawing.Size(666, 386);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tbtn_Adicionar;
        private System.Windows.Forms.ToolStripButton tBtn_Editar;
        private System.Windows.Forms.ToolStripButton tBtn_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tBtn_Excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Tbtn_Pesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Tbtn_Cancelar;
    }
}
