namespace Client
{
    partial class NATIONALWS
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
            this.lb_CountryCode = new System.Windows.Forms.Label();
            this.lb_CityName = new System.Windows.Forms.Label();
            this.txb_CountryCode = new System.Windows.Forms.TextBox();
            this.txb_CityName = new System.Windows.Forms.TextBox();
            this.getAllCountry = new System.Windows.Forms.Button();
            this.getCountrybyCode = new System.Windows.Forms.Button();
            this.getCityByName = new System.Windows.Forms.Button();
            this.getAllCityFromCountry = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btn_GetPresidentName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CountryCode
            // 
            this.lb_CountryCode.AutoSize = true;
            this.lb_CountryCode.Location = new System.Drawing.Point(7, 12);
            this.lb_CountryCode.Name = "lb_CountryCode";
            this.lb_CountryCode.Size = new System.Drawing.Size(81, 16);
            this.lb_CountryCode.TabIndex = 0;
            this.lb_CountryCode.Text = "Ma quoc gia";
            this.lb_CountryCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_CityName
            // 
            this.lb_CityName.AutoSize = true;
            this.lb_CityName.Location = new System.Drawing.Point(7, 40);
            this.lb_CityName.Name = "lb_CityName";
            this.lb_CityName.Size = new System.Drawing.Size(92, 16);
            this.lb_CityName.TabIndex = 1;
            this.lb_CityName.Text = "Ten thanh pho";
            // 
            // txb_CountryCode
            // 
            this.txb_CountryCode.Location = new System.Drawing.Point(105, 12);
            this.txb_CountryCode.Name = "txb_CountryCode";
            this.txb_CountryCode.Size = new System.Drawing.Size(126, 22);
            this.txb_CountryCode.TabIndex = 2;
            // 
            // txb_CityName
            // 
            this.txb_CityName.Location = new System.Drawing.Point(105, 37);
            this.txb_CityName.Name = "txb_CityName";
            this.txb_CityName.Size = new System.Drawing.Size(126, 22);
            this.txb_CityName.TabIndex = 3;
            // 
            // getAllCountry
            // 
            this.getAllCountry.Location = new System.Drawing.Point(6, 64);
            this.getAllCountry.Name = "getAllCountry";
            this.getAllCountry.Size = new System.Drawing.Size(161, 23);
            this.getAllCountry.TabIndex = 5;
            this.getAllCountry.Text = "Tat ca quoc gia";
            this.getAllCountry.UseVisualStyleBackColor = true;
            this.getAllCountry.Click += new System.EventHandler(this.button1_Click);
            // 
            // getCountrybyCode
            // 
            this.getCountrybyCode.Location = new System.Drawing.Point(6, 93);
            this.getCountrybyCode.Name = "getCountrybyCode";
            this.getCountrybyCode.Size = new System.Drawing.Size(161, 23);
            this.getCountrybyCode.TabIndex = 6;
            this.getCountrybyCode.Text = "Goi bang ma so";
            this.getCountrybyCode.UseVisualStyleBackColor = true;
            this.getCountrybyCode.Click += new System.EventHandler(this.getCountrybyCode_Click);
            // 
            // getCityByName
            // 
            this.getCityByName.Location = new System.Drawing.Point(6, 122);
            this.getCityByName.Name = "getCityByName";
            this.getCityByName.Size = new System.Drawing.Size(161, 23);
            this.getCityByName.TabIndex = 7;
            this.getCityByName.Text = "Goi bang ten";
            this.getCityByName.UseVisualStyleBackColor = true;
            this.getCityByName.Click += new System.EventHandler(this.getCityByName_Click);
            // 
            // getAllCityFromCountry
            // 
            this.getAllCityFromCountry.Location = new System.Drawing.Point(173, 64);
            this.getAllCityFromCountry.Name = "getAllCityFromCountry";
            this.getAllCityFromCountry.Size = new System.Drawing.Size(126, 81);
            this.getAllCityFromCountry.TabIndex = 8;
            this.getAllCityFromCountry.Text = "Xem tat ca thanh pho cua quoc gia";
            this.getAllCityFromCountry.UseVisualStyleBackColor = true;
            this.getAllCityFromCountry.Click += new System.EventHandler(this.getAllCityFromCountry_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvResults.Location = new System.Drawing.Point(6, 151);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(425, 213);
            this.dgvResults.TabIndex = 10;
            // 
            // btn_GetPresidentName
            // 
            this.btn_GetPresidentName.Location = new System.Drawing.Point(305, 64);
            this.btn_GetPresidentName.Name = "btn_GetPresidentName";
            this.btn_GetPresidentName.Size = new System.Drawing.Size(126, 81);
            this.btn_GetPresidentName.TabIndex = 11;
            this.btn_GetPresidentName.Text = "Ai la tong thong ?";
            this.btn_GetPresidentName.UseVisualStyleBackColor = true;
            this.btn_GetPresidentName.Click += new System.EventHandler(this.btn_GetPresidentName_Click);
            // 
            // NATIONALWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 371);
            this.Controls.Add(this.btn_GetPresidentName);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.getAllCityFromCountry);
            this.Controls.Add(this.getCityByName);
            this.Controls.Add(this.getCountrybyCode);
            this.Controls.Add(this.getAllCountry);
            this.Controls.Add(this.txb_CityName);
            this.Controls.Add(this.txb_CountryCode);
            this.Controls.Add(this.lb_CityName);
            this.Controls.Add(this.lb_CountryCode);
            this.Name = "NATIONALWS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NATIONALWS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CountryCode;
        private System.Windows.Forms.Label lb_CityName;
        private System.Windows.Forms.TextBox txb_CountryCode;
        private System.Windows.Forms.TextBox txb_CityName;
        private System.Windows.Forms.Button getAllCountry;
        private System.Windows.Forms.Button getCountrybyCode;
        private System.Windows.Forms.Button getCityByName;
        private System.Windows.Forms.Button getAllCityFromCountry;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btn_GetPresidentName;
    }
}