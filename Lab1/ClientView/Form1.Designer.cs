namespace ClientView
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
            this.lb_CountryCode = new System.Windows.Forms.Label();
            this.lb_CityName = new System.Windows.Forms.Label();
            this.txb_CountryCode = new System.Windows.Forms.TextBox();
            this.txb_CityName = new System.Windows.Forms.TextBox();
            this.getAllCountry = new System.Windows.Forms.Button();
            this.getCountrybyCode = new System.Windows.Forms.Button();
            this.getCityByName = new System.Windows.Forms.Button();
            this.getAllCityFromCountry = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CountryCode
            // 
            this.lb_CountryCode.AutoSize = true;
            this.lb_CountryCode.Location = new System.Drawing.Point(79, 64);
            this.lb_CountryCode.Name = "lb_CountryCode";
            this.lb_CountryCode.Size = new System.Drawing.Size(88, 16);
            this.lb_CountryCode.TabIndex = 0;
            this.lb_CountryCode.Text = "Country Code";
            this.lb_CountryCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_CityName
            // 
            this.lb_CityName.AutoSize = true;
            this.lb_CityName.Location = new System.Drawing.Point(79, 111);
            this.lb_CityName.Name = "lb_CityName";
            this.lb_CityName.Size = new System.Drawing.Size(69, 16);
            this.lb_CityName.TabIndex = 1;
            this.lb_CityName.Text = "City Name";
            this.lb_CityName.Click += new System.EventHandler(this.lb_CityName_Click);
            // 
            // txb_CountryCode
            // 
            this.txb_CountryCode.Location = new System.Drawing.Point(238, 64);
            this.txb_CountryCode.Name = "txb_CountryCode";
            this.txb_CountryCode.Size = new System.Drawing.Size(100, 22);
            this.txb_CountryCode.TabIndex = 2;
            this.txb_CountryCode.TextChanged += new System.EventHandler(this.txb_CountryCode_TextChanged);
            // 
            // txb_CityName
            // 
            this.txb_CityName.Location = new System.Drawing.Point(238, 105);
            this.txb_CityName.Name = "txb_CityName";
            this.txb_CityName.Size = new System.Drawing.Size(100, 22);
            this.txb_CityName.TabIndex = 3;
            this.txb_CityName.TextChanged += new System.EventHandler(this.txb_CityName_TextChanged);
            // 
            // getAllCountry
            // 
            this.getAllCountry.Location = new System.Drawing.Point(381, 57);
            this.getAllCountry.Name = "getAllCountry";
            this.getAllCountry.Size = new System.Drawing.Size(161, 23);
            this.getAllCountry.TabIndex = 5;
            this.getAllCountry.Text = "getAllCountry";
            this.getAllCountry.UseVisualStyleBackColor = true;
            this.getAllCountry.Click += new System.EventHandler(this.button1_Click);
            // 
            // getCountrybyCode
            // 
            this.getCountrybyCode.Location = new System.Drawing.Point(381, 104);
            this.getCountrybyCode.Name = "getCountrybyCode";
            this.getCountrybyCode.Size = new System.Drawing.Size(161, 23);
            this.getCountrybyCode.TabIndex = 6;
            this.getCountrybyCode.Text = "getCountrybyCode";
            this.getCountrybyCode.UseVisualStyleBackColor = true;
            this.getCountrybyCode.Click += new System.EventHandler(this.getCountrybyCode_Click);
            // 
            // getCityByName
            // 
            this.getCityByName.Location = new System.Drawing.Point(600, 57);
            this.getCityByName.Name = "getCityByName";
            this.getCityByName.Size = new System.Drawing.Size(130, 23);
            this.getCityByName.TabIndex = 7;
            this.getCityByName.Text = "getCityByName";
            this.getCityByName.UseVisualStyleBackColor = true;
            this.getCityByName.Click += new System.EventHandler(this.getCityByName_Click);
            // 
            // getAllCityFromCountry
            // 
            this.getAllCityFromCountry.Location = new System.Drawing.Point(600, 104);
            this.getAllCityFromCountry.Name = "getAllCityFromCountry";
            this.getAllCityFromCountry.Size = new System.Drawing.Size(130, 42);
            this.getAllCityFromCountry.TabIndex = 8;
            this.getAllCityFromCountry.Text = "getAllCityFromCountry";
            this.getAllCityFromCountry.UseVisualStyleBackColor = true;
            this.getAllCityFromCountry.Click += new System.EventHandler(this.getAllCityFromCountry_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(73, 224);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(671, 195);
            this.dgvResults.TabIndex = 10;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.getAllCityFromCountry);
            this.Controls.Add(this.getCityByName);
            this.Controls.Add(this.getCountrybyCode);
            this.Controls.Add(this.getAllCountry);
            this.Controls.Add(this.txb_CityName);
            this.Controls.Add(this.txb_CountryCode);
            this.Controls.Add(this.lb_CityName);
            this.Controls.Add(this.lb_CountryCode);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}