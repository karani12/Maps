namespace Maps
{
    partial class form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.streetlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statelabel = new System.Windows.Forms.Label();
            this.zipcodelabel = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.citylabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.citylabel);
            this.splitContainer1.Panel1.Controls.Add(this.searchbtn);
            this.splitContainer1.Panel1.Controls.Add(this.zipcodelabel);
            this.splitContainer1.Panel1.Controls.Add(this.statelabel);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.streetlabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxCity);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxState);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxZip);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxStreet);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(916, 450);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(607, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(87, 32);
            this.txtBoxStreet.Multiline = true;
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(157, 32);
            this.txtBoxStreet.TabIndex = 0;
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(87, 213);
            this.txtBoxZip.Multiline = true;
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(157, 32);
            this.txtBoxZip.TabIndex = 1;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(87, 152);
            this.txtBoxState.Multiline = true;
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(157, 32);
            this.txtBoxState.TabIndex = 2;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(87, 99);
            this.txtBoxCity.Multiline = true;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(157, 32);
            this.txtBoxCity.TabIndex = 3;
            // 
            // streetlabel
            // 
            this.streetlabel.AutoSize = true;
            this.streetlabel.Location = new System.Drawing.Point(12, 35);
            this.streetlabel.Name = "streetlabel";
            this.streetlabel.Size = new System.Drawing.Size(41, 16);
            this.streetlabel.TabIndex = 4;
            this.streetlabel.Text = "street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.Location = new System.Drawing.Point(12, 155);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(36, 16);
            this.statelabel.TabIndex = 6;
            this.statelabel.Text = "state";
            // 
            // zipcodelabel
            // 
            this.zipcodelabel.AutoSize = true;
            this.zipcodelabel.Location = new System.Drawing.Point(12, 213);
            this.zipcodelabel.Name = "zipcodelabel";
            this.zipcodelabel.Size = new System.Drawing.Size(57, 16);
            this.zipcodelabel.TabIndex = 7;
            this.zipcodelabel.Text = "zipcode";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Blue;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Location = new System.Drawing.Point(87, 273);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(141, 31);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.Location = new System.Drawing.Point(12, 102);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(31, 16);
            this.citylabel.TabIndex = 9;
            this.citylabel.Text = "city";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "form";
            this.Text = "Maps";
            this.Load += new System.EventHandler(this.form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label zipcodelabel;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label streetlabel;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label citylabel;
    }
}

