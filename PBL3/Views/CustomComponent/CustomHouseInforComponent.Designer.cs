﻿
namespace PBL3.Views.CustomComponent
{
    partial class CustomHouseInforComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tienLabel = new System.Windows.Forms.Label();
            this.dienTichLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.mieuTaLabel = new System.Windows.Forms.Label();
            this.postID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tenNhaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 314);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::PBL3.Properties.Resources.logo1;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.background;
            this.pictureBox1.InitialImage = global::PBL3.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tienLabel
            // 
            this.tienLabel.AutoSize = true;
            this.tienLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienLabel.ForeColor = System.Drawing.Color.Red;
            this.tienLabel.Location = new System.Drawing.Point(75, 113);
            this.tienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tienLabel.Name = "tienLabel";
            this.tienLabel.Size = new System.Drawing.Size(93, 28);
            this.tienLabel.TabIndex = 7;
            this.tienLabel.Text = "Số tiền : ";
            // 
            // dienTichLabel
            // 
            this.dienTichLabel.AutoSize = true;
            this.dienTichLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienTichLabel.ForeColor = System.Drawing.Color.Red;
            this.dienTichLabel.Location = new System.Drawing.Point(259, 113);
            this.dienTichLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dienTichLabel.Name = "dienTichLabel";
            this.dienTichLabel.Size = new System.Drawing.Size(129, 28);
            this.dienTichLabel.TabIndex = 8;
            this.dienTichLabel.Text = "Mét vuông : ";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiLabel.ForeColor = System.Drawing.Color.DimGray;
            this.diaChiLabel.Location = new System.Drawing.Point(138, 167);
            this.diaChiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(260, 28);
            this.diaChiLabel.TabIndex = 9;
            this.diaChiLabel.Text = "Hòa Khánh Bắc, Liên CHiểu";
            // 
            // mieuTaLabel
            // 
            this.mieuTaLabel.AutoSize = true;
            this.mieuTaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mieuTaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.mieuTaLabel.Location = new System.Drawing.Point(75, 233);
            this.mieuTaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mieuTaLabel.Name = "mieuTaLabel";
            this.mieuTaLabel.Size = new System.Drawing.Size(98, 28);
            this.mieuTaLabel.TabIndex = 10;
            this.mieuTaLabel.Text = "Miêu tả : ";
            // 
            // postID
            // 
            this.postID.AutoSize = true;
            this.postID.Location = new System.Drawing.Point(82, 16);
            this.postID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postID.Name = "postID";
            this.postID.Size = new System.Drawing.Size(46, 16);
            this.postID.TabIndex = 12;
            this.postID.Text = "postID";
            this.postID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.postID);
            this.panel2.Controls.Add(this.tenNhaLinkLabel);
            this.panel2.Controls.Add(this.mieuTaLabel);
            this.panel2.Controls.Add(this.diaChiLabel);
            this.panel2.Controls.Add(this.dienTichLabel);
            this.panel2.Controls.Add(this.tienLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(316, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 314);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3.Properties.Resources.iconaddress1;
            this.pictureBox2.Location = new System.Drawing.Point(85, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // tenNhaLinkLabel
            // 
            this.tenNhaLinkLabel.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.tenNhaLinkLabel.AutoSize = true;
            this.tenNhaLinkLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNhaLinkLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.tenNhaLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.tenNhaLinkLabel.Location = new System.Drawing.Point(71, 45);
            this.tenNhaLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenNhaLinkLabel.Name = "tenNhaLinkLabel";
            this.tenNhaLinkLabel.Size = new System.Drawing.Size(169, 54);
            this.tenNhaLinkLabel.TabIndex = 11;
            this.tenNhaLinkLabel.TabStop = true;
            this.tenNhaLinkLabel.Text = "Tên nhà";
            this.tenNhaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tenNhaLinkLabel_LinkClicked);
            // 
            // CustomHouseInforComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomHouseInforComponent";
            this.Size = new System.Drawing.Size(1026, 314);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tienLabel;
        private System.Windows.Forms.Label dienTichLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label mieuTaLabel;
        private System.Windows.Forms.Label postID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel tenNhaLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
