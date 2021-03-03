
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridLog = new System.Windows.Forms.DataGridView();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.dataGridResponse = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPyPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pruevasAutomaticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResponse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(758, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridLog
            // 
            this.dataGridLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLog.Location = new System.Drawing.Point(26, 28);
            this.dataGridLog.Name = "dataGridLog";
            this.dataGridLog.Size = new System.Drawing.Size(726, 175);
            this.dataGridLog.TabIndex = 4;
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRequest.Location = new System.Drawing.Point(26, 209);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ReadOnly = true;
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRequest.Size = new System.Drawing.Size(726, 134);
            this.textBoxRequest.TabIndex = 5;
            // 
            // dataGridResponse
            // 
            this.dataGridResponse.AllowUserToOrderColumns = true;
            this.dataGridResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResponse.Location = new System.Drawing.Point(26, 346);
            this.dataGridResponse.Name = "dataGridResponse";
            this.dataGridResponse.Size = new System.Drawing.Size(726, 124);
            this.dataGridResponse.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
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
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(271, 476);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(223, 29);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refescar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // pruevasAutomaticasToolStripMenuItem
            // 
            this.pruevasAutomaticasToolStripMenuItem.Name = "pruevasAutomaticasToolStripMenuItem";
            this.pruevasAutomaticasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pruevasAutomaticasToolStripMenuItem.Text = "Pruevas Automaticas";
            this.pruevasAutomaticasToolStripMenuItem.Click += new System.EventHandler(this.pruevasAutomaticasToolStripMenuItem_Click);
            // 
            // MonolithConect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridResponse);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.dataGridLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MonolithConect";
            this.Text = "MonolithConect";
            this.Load += new System.EventHandler(this.MonolithConect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResponse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridLog;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.DataGridView dataGridResponse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPyPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshTimeToolStripMenuItem;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem pruevasAutomaticasToolStripMenuItem;
    }
}

