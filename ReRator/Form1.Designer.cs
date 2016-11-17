namespace ReRator
{
    partial class Form1
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
            this.pnlIterations = new System.Windows.Forms.Panel();
            this.gbxSelectRace = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbxCourses = new System.Windows.Forms.ListBox();
            this.lbxRaceNumbers = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.gbxStart = new System.Windows.Forms.GroupBox();
            this.dgvStart = new System.Windows.Forms.DataGridView();
            this.pnlIterations.SuspendLayout();
            this.gbxSelectRace.SuspendLayout();
            this.gbxStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIterations
            // 
            this.pnlIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIterations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlIterations.Controls.Add(this.vScrollBar1);
            this.pnlIterations.Location = new System.Drawing.Point(511, 12);
            this.pnlIterations.Name = "pnlIterations";
            this.pnlIterations.Size = new System.Drawing.Size(820, 835);
            this.pnlIterations.TabIndex = 0;
            // 
            // gbxSelectRace
            // 
            this.gbxSelectRace.Controls.Add(this.lbxRaceNumbers);
            this.gbxSelectRace.Controls.Add(this.lbxCourses);
            this.gbxSelectRace.Controls.Add(this.monthCalendar1);
            this.gbxSelectRace.Location = new System.Drawing.Point(3, 6);
            this.gbxSelectRace.Name = "gbxSelectRace";
            this.gbxSelectRace.Size = new System.Drawing.Size(502, 397);
            this.gbxSelectRace.TabIndex = 1;
            this.gbxSelectRace.TabStop = false;
            this.gbxSelectRace.Text = "Select a race";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lbxCourses
            // 
            this.lbxCourses.FormattingEnabled = true;
            this.lbxCourses.Location = new System.Drawing.Point(262, 32);
            this.lbxCourses.Name = "lbxCourses";
            this.lbxCourses.Size = new System.Drawing.Size(170, 160);
            this.lbxCourses.TabIndex = 1;
            // 
            // lbxRaceNumbers
            // 
            this.lbxRaceNumbers.FormattingEnabled = true;
            this.lbxRaceNumbers.Location = new System.Drawing.Point(438, 32);
            this.lbxRaceNumbers.Name = "lbxRaceNumbers";
            this.lbxRaceNumbers.Size = new System.Drawing.Size(51, 160);
            this.lbxRaceNumbers.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(803, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 835);
            this.vScrollBar1.TabIndex = 0;
            // 
            // gbxStart
            // 
            this.gbxStart.Controls.Add(this.dgvStart);
            this.gbxStart.Location = new System.Drawing.Point(3, 430);
            this.gbxStart.Name = "gbxStart";
            this.gbxStart.Size = new System.Drawing.Size(502, 193);
            this.gbxStart.TabIndex = 2;
            this.gbxStart.TabStop = false;
            this.gbxStart.Text = "Starting Point";
            // 
            // dgvStart
            // 
            this.dgvStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStart.Location = new System.Drawing.Point(3, 16);
            this.dgvStart.Name = "dgvStart";
            this.dgvStart.Size = new System.Drawing.Size(496, 174);
            this.dgvStart.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 850);
            this.Controls.Add(this.gbxStart);
            this.Controls.Add(this.gbxSelectRace);
            this.Controls.Add(this.pnlIterations);
            this.Name = "Form1";
            this.Text = "ReRator";
            this.pnlIterations.ResumeLayout(false);
            this.gbxSelectRace.ResumeLayout(false);
            this.gbxStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIterations;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox gbxSelectRace;
        private System.Windows.Forms.ListBox lbxRaceNumbers;
        private System.Windows.Forms.ListBox lbxCourses;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox gbxStart;
        private System.Windows.Forms.DataGridView dgvStart;

    }
}

