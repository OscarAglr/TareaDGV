namespace PooApps2m1
{
    partial class FrmDepreciacion
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
            this.dgvDepreciacion = new System.Windows.Forms.DataGridView();
            this.txtFinder = new System.Windows.Forms.TextBox();
            this.cmbMetodos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepreciacion
            // 
            this.dgvDepreciacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepreciacion.Location = new System.Drawing.Point(18, 97);
            this.dgvDepreciacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDepreciacion.Name = "dgvDepreciacion";
            this.dgvDepreciacion.RowHeadersWidth = 62;
            this.dgvDepreciacion.Size = new System.Drawing.Size(824, 615);
            this.dgvDepreciacion.TabIndex = 0;
            // 
            // txtFinder
            // 
            this.txtFinder.Location = new System.Drawing.Point(18, 57);
            this.txtFinder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Size = new System.Drawing.Size(822, 26);
            this.txtFinder.TabIndex = 1;
            this.txtFinder.TextChanged += new System.EventHandler(this.txtFinder_TextChanged);
            // 
            // cmbMetodos
            // 
            this.cmbMetodos.FormattingEnabled = true;
            this.cmbMetodos.Location = new System.Drawing.Point(188, 15);
            this.cmbMetodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetodos.Name = "cmbMetodos";
            this.cmbMetodos.Size = new System.Drawing.Size(252, 28);
            this.cmbMetodos.TabIndex = 2;
            this.cmbMetodos.SelectedIndexChanged += new System.EventHandler(this.cmbMetodos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Metodo depreciacion";
            // 
            // FrmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMetodos);
            this.Controls.Add(this.txtFinder);
            this.Controls.Add(this.dgvDepreciacion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDepreciacion";
            this.Text = "FrmDepreciacion";
            this.Load += new System.EventHandler(this.FrmDepreciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepreciacion;
        private System.Windows.Forms.TextBox txtFinder;
        private System.Windows.Forms.ComboBox cmbMetodos;
        private System.Windows.Forms.Label label1;
    }
}