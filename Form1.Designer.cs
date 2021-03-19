
namespace MonolithConect
{
    partial class MonolithConect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonolithConect));
            this.dataGridLog = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPyPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruevasAutomaticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridLog
            // 
            this.dataGridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLog.Location = new System.Drawing.Point(26, 28);
            this.dataGridLog.Name = "dataGridLog";
            this.dataGridLog.Size = new System.Drawing.Size(410, 102);
            this.dataGridLog.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem,
            this.cerrarProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPyPortToolStripMenuItem,
            this.refreshTimeToolStripMenuItem,
            this.pruevasAutomaticasToolStripMenuItem});
            this.setUpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.setUpToolStripMenuItem.Text = "SetUp";
            // 
            // iPyPortToolStripMenuItem
            // 
            this.iPyPortToolStripMenuItem.Name = "iPyPortToolStripMenuItem";
            this.iPyPortToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.iPyPortToolStripMenuItem.Text = "IPAndPort";
            this.iPyPortToolStripMenuItem.Click += new System.EventHandler(this.iPyPortToolStripMenuItem_Click);
            // 
            // refreshTimeToolStripMenuItem
            // 
            this.refreshTimeToolStripMenuItem.Name = "refreshTimeToolStripMenuItem";
            this.refreshTimeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.refreshTimeToolStripMenuItem.Text = "Refresh Time";
            this.refreshTimeToolStripMenuItem.Click += new System.EventHandler(this.refreshTimeToolStripMenuItem_Click);
            // 
            // pruevasAutomaticasToolStripMenuItem
            // 
            this.pruevasAutomaticasToolStripMenuItem.Name = "pruevasAutomaticasToolStripMenuItem";
            this.pruevasAutomaticasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pruevasAutomaticasToolStripMenuItem.Text = "Pruevas Automaticas";
            this.pruevasAutomaticasToolStripMenuItem.Click += new System.EventHandler(this.pruevasAutomaticasToolStripMenuItem_Click);
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.cerrarProgramaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar Programa";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(87, 176);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(120, 61);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refescar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar Gues In House";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlert.Location = new System.Drawing.Point(34, 253);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(425, 13);
            this.labelAlert.TabIndex = 10;
            this.labelAlert.Text = "Por Favor Referscar Solo despues de dar checkIn al cliente en el sistema";
            // 
            // MonolithConect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.ControlBox = false;
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridLog);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MonolithConect";
            this.Text = "MonolithConect";
            this.Load += new System.EventHandler(this.MonolithConect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPyPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshTimeToolStripMenuItem;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem pruevasAutomaticasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}

