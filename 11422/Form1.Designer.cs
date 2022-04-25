namespace _11422
{
    partial class lbCaptainHome
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
            this.cbHome = new System.Windows.Forms.ComboBox();
            this.cbAway = new System.Windows.Forms.ComboBox();
            this.lbVs = new System.Windows.Forms.Label();
            this.lbManagerHome = new System.Windows.Forms.Label();
            this.lbManagerAway = new System.Windows.Forms.Label();
            this.lbCaptHome = new System.Windows.Forms.Label();
            this.lbCaptainAway = new System.Windows.Forms.Label();
            this.lbStadium = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.MatchDetail = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.lbSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MatchDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHome
            // 
            this.cbHome.FormattingEnabled = true;
            this.cbHome.Location = new System.Drawing.Point(54, 29);
            this.cbHome.Name = "cbHome";
            this.cbHome.Size = new System.Drawing.Size(160, 21);
            this.cbHome.TabIndex = 0;
            this.cbHome.SelectedIndexChanged += new System.EventHandler(this.cbHome_SelectedIndexChanged);
            // 
            // cbAway
            // 
            this.cbAway.FormattingEnabled = true;
            this.cbAway.Location = new System.Drawing.Point(489, 29);
            this.cbAway.Name = "cbAway";
            this.cbAway.Size = new System.Drawing.Size(139, 21);
            this.cbAway.TabIndex = 1;
            this.cbAway.SelectedIndexChanged += new System.EventHandler(this.cbAway_SelectedIndexChanged);
            // 
            // lbVs
            // 
            this.lbVs.AutoSize = true;
            this.lbVs.Location = new System.Drawing.Point(331, 36);
            this.lbVs.Name = "lbVs";
            this.lbVs.Size = new System.Drawing.Size(18, 13);
            this.lbVs.TabIndex = 2;
            this.lbVs.Text = "vs";
            // 
            // lbManagerHome
            // 
            this.lbManagerHome.AutoSize = true;
            this.lbManagerHome.Location = new System.Drawing.Point(54, 57);
            this.lbManagerHome.Name = "lbManagerHome";
            this.lbManagerHome.Size = new System.Drawing.Size(55, 13);
            this.lbManagerHome.TabIndex = 3;
            this.lbManagerHome.Text = "Manager :";
            // 
            // lbManagerAway
            // 
            this.lbManagerAway.AutoSize = true;
            this.lbManagerAway.Location = new System.Drawing.Point(489, 57);
            this.lbManagerAway.Name = "lbManagerAway";
            this.lbManagerAway.Size = new System.Drawing.Size(55, 13);
            this.lbManagerAway.TabIndex = 4;
            this.lbManagerAway.Text = "Manager :";
            // 
            // lbCaptHome
            // 
            this.lbCaptHome.AutoSize = true;
            this.lbCaptHome.Location = new System.Drawing.Point(54, 73);
            this.lbCaptHome.Name = "lbCaptHome";
            this.lbCaptHome.Size = new System.Drawing.Size(52, 13);
            this.lbCaptHome.TabIndex = 5;
            this.lbCaptHome.Text = "Captain : ";
            // 
            // lbCaptainAway
            // 
            this.lbCaptainAway.AutoSize = true;
            this.lbCaptainAway.Location = new System.Drawing.Point(489, 73);
            this.lbCaptainAway.Name = "lbCaptainAway";
            this.lbCaptainAway.Size = new System.Drawing.Size(49, 13);
            this.lbCaptainAway.TabIndex = 6;
            this.lbCaptainAway.Text = "Captain :";
            // 
            // lbStadium
            // 
            this.lbStadium.AutoSize = true;
            this.lbStadium.Location = new System.Drawing.Point(309, 106);
            this.lbStadium.Name = "lbStadium";
            this.lbStadium.Size = new System.Drawing.Size(45, 13);
            this.lbStadium.TabIndex = 7;
            this.lbStadium.Text = "Stadium";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(309, 119);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(57, 13);
            this.lbCapacity.TabIndex = 8;
            this.lbCapacity.Text = "Capacity : ";
            // 
            // MatchDetail
            // 
            this.MatchDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchDetail.Location = new System.Drawing.Point(57, 233);
            this.MatchDetail.Name = "MatchDetail";
            this.MatchDetail.Size = new System.Drawing.Size(623, 150);
            this.MatchDetail.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(299, 144);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Location = new System.Drawing.Point(279, 179);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(52, 13);
            this.lbTanggal.TabIndex = 11;
            this.lbTanggal.Text = "Tanggal :";
            // 
            // lbSkor
            // 
            this.lbSkor.AutoSize = true;
            this.lbSkor.Location = new System.Drawing.Point(296, 192);
            this.lbSkor.Name = "lbSkor";
            this.lbSkor.Size = new System.Drawing.Size(35, 13);
            this.lbSkor.TabIndex = 12;
            this.lbSkor.Text = "Skor :";
            // 
            // lbCaptainHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSkor);
            this.Controls.Add(this.lbTanggal);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.MatchDetail);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbStadium);
            this.Controls.Add(this.lbCaptainAway);
            this.Controls.Add(this.lbCaptHome);
            this.Controls.Add(this.lbManagerAway);
            this.Controls.Add(this.lbManagerHome);
            this.Controls.Add(this.lbVs);
            this.Controls.Add(this.cbAway);
            this.Controls.Add(this.cbHome);
            this.Name = "lbCaptainHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPraktikum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatchDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHome;
        private System.Windows.Forms.ComboBox cbAway;
        private System.Windows.Forms.Label lbVs;
        private System.Windows.Forms.Label lbManagerHome;
        private System.Windows.Forms.Label lbManagerAway;
        private System.Windows.Forms.Label lbCaptHome;
        private System.Windows.Forms.Label lbCaptainAway;
        private System.Windows.Forms.Label lbStadium;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.DataGridView MatchDetail;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.Label lbSkor;
    }
}

