
namespace MonolithConect
{
    partial class GuestInHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestInHouse));
            this.dataGridViewAcceso = new System.Windows.Forms.DataGridView();
            this.dataGridViewSinAcceso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinAcceso)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAcceso
            // 
            this.dataGridViewAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAcceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcceso.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewAcceso.Name = "dataGridViewAcceso";
            this.dataGridViewAcceso.Size = new System.Drawing.Size(1150, 183);
            this.dataGridViewAcceso.TabIndex = 0;
            // 
            // dataGridViewSinAcceso
            // 
            this.dataGridViewSinAcceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinAcceso.Location = new System.Drawing.Point(12, 253);
            this.dataGridViewSinAcceso.Name = "dataGridViewSinAcceso";
            this.dataGridViewSinAcceso.Size = new System.Drawing.Size(1150, 185);
            this.dataGridViewSinAcceso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes con Acceso al App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes sin Acceso al App";
            // 
            // GuestInHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSinAcceso);
            this.Controls.Add(this.dataGridViewAcceso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestInHouse";
            this.Text = "GuestInHouse";
            this.Load += new System.EventHandler(this.GuestInHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinAcceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAcceso;
        private System.Windows.Forms.DataGridView dataGridViewSinAcceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}