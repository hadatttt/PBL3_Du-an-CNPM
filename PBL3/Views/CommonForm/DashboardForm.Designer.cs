namespace PBL3.Views.CommonForm
{
    partial class DashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.customButton1 = new PBL3.Views.CustomComponent.CustomButton();
            this.customToggleButton1 = new PBL3.Views.CustomComponent.CustomToggleButton();
            this.customComboBox1 = new PBL3.Views.CustomComponent.CustomComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 183);
            this.panel1.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 8;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(228, 202);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(178, 34);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customToggleButton1
            // 
            this.customToggleButton1.AutoSize = true;
            this.customToggleButton1.Location = new System.Drawing.Point(373, 283);
            this.customToggleButton1.Name = "customToggleButton1";
            this.customToggleButton1.Size = new System.Drawing.Size(160, 20);
            this.customToggleButton1.TabIndex = 2;
            this.customToggleButton1.Text = "customToggleButton1";
            this.customToggleButton1.UseVisualStyleBackColor = true;
            // 
            // customComboBox1
            // 
            this.customComboBox1.Location = new System.Drawing.Point(31, 202);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(191, 26);
            this.customComboBox1.TabIndex = 3;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.customToggleButton1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomComponent.CustomButton customButton1;
        private CustomComponent.CustomToggleButton customToggleButton1;
        private CustomComponent.CustomComboBox customComboBox1;
    }
}