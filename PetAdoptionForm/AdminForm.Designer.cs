namespace PetAdoptionForm
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_accept = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_refuse = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.list_requests = new Krypton.Toolkit.KryptonCheckedListBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.list_request2 = new Krypton.Toolkit.KryptonCheckedListBox();
            this.btn_accept2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_refuse2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(222, -2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel1.Size = new System.Drawing.Size(157, 44);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Admin Panel";
            this.kryptonLabel1.Click += new System.EventHandler(this.kryptonLabel1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(29, 95);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Animated = true;
            this.btn_accept.AutoRoundedCorners = true;
            this.btn_accept.BackColor = System.Drawing.Color.Transparent;
            this.btn_accept.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_accept.BorderRadius = 21;
            this.btn_accept.BorderThickness = 2;
            this.btn_accept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_accept.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_accept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_accept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_accept.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_accept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_accept.ForeColor = System.Drawing.Color.White;
            this.btn_accept.Location = new System.Drawing.Point(3, 302);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(113, 45);
            this.btn_accept.TabIndex = 3;
            this.btn_accept.Text = "Onayla";
            this.btn_accept.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btn_refuse
            // 
            this.btn_refuse.Animated = true;
            this.btn_refuse.AutoRoundedCorners = true;
            this.btn_refuse.BackColor = System.Drawing.Color.Transparent;
            this.btn_refuse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refuse.BorderRadius = 21;
            this.btn_refuse.BorderThickness = 2;
            this.btn_refuse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refuse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refuse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refuse.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refuse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refuse.FillColor = System.Drawing.Color.Red;
            this.btn_refuse.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refuse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refuse.ForeColor = System.Drawing.Color.White;
            this.btn_refuse.Location = new System.Drawing.Point(154, 302);
            this.btn_refuse.Name = "btn_refuse";
            this.btn_refuse.Size = new System.Drawing.Size(113, 45);
            this.btn_refuse.TabIndex = 4;
            this.btn_refuse.Text = "Reddet";
            this.btn_refuse.Click += new System.EventHandler(this.btn_refuse_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.list_requests);
            this.guna2GradientPanel1.Controls.Add(this.btn_accept);
            this.guna2GradientPanel1.Controls.Add(this.btn_refuse);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(444, 48);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(270, 350);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // list_requests
            // 
            this.list_requests.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.list_requests.CheckOnClick = true;
            this.list_requests.Location = new System.Drawing.Point(0, 3);
            this.list_requests.Name = "list_requests";
            this.list_requests.Size = new System.Drawing.Size(267, 296);
            this.list_requests.Sorted = true;
            this.list_requests.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.list_requests.TabIndex = 5;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.list_request2);
            this.guna2GradientPanel2.Controls.Add(this.btn_accept2);
            this.guna2GradientPanel2.Controls.Add(this.btn_refuse2);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(749, 48);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(270, 350);
            this.guna2GradientPanel2.TabIndex = 6;
            // 
            // list_request2
            // 
            this.list_request2.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.list_request2.CheckOnClick = true;
            this.list_request2.Location = new System.Drawing.Point(3, 0);
            this.list_request2.Name = "list_request2";
            this.list_request2.Size = new System.Drawing.Size(267, 296);
            this.list_request2.Sorted = true;
            this.list_request2.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.list_request2.TabIndex = 5;
            // 
            // btn_accept2
            // 
            this.btn_accept2.Animated = true;
            this.btn_accept2.AutoRoundedCorners = true;
            this.btn_accept2.BackColor = System.Drawing.Color.Transparent;
            this.btn_accept2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_accept2.BorderRadius = 21;
            this.btn_accept2.BorderThickness = 2;
            this.btn_accept2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_accept2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_accept2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_accept2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_accept2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_accept2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_accept2.ForeColor = System.Drawing.Color.White;
            this.btn_accept2.Location = new System.Drawing.Point(3, 302);
            this.btn_accept2.Name = "btn_accept2";
            this.btn_accept2.Size = new System.Drawing.Size(113, 45);
            this.btn_accept2.TabIndex = 3;
            this.btn_accept2.Text = "Onayla";
            this.btn_accept2.Click += new System.EventHandler(this.btn_accept2_Click);
            // 
            // btn_refuse2
            // 
            this.btn_refuse2.Animated = true;
            this.btn_refuse2.AutoRoundedCorners = true;
            this.btn_refuse2.BackColor = System.Drawing.Color.Transparent;
            this.btn_refuse2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refuse2.BorderRadius = 21;
            this.btn_refuse2.BorderThickness = 2;
            this.btn_refuse2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refuse2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refuse2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refuse2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refuse2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refuse2.FillColor = System.Drawing.Color.Red;
            this.btn_refuse2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refuse2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refuse2.ForeColor = System.Drawing.Color.White;
            this.btn_refuse2.Location = new System.Drawing.Point(154, 302);
            this.btn_refuse2.Name = "btn_refuse2";
            this.btn_refuse2.Size = new System.Drawing.Size(113, 45);
            this.btn_refuse2.TabIndex = 4;
            this.btn_refuse2.Text = "Reddet";
            this.btn_refuse2.Click += new System.EventHandler(this.btn_refuse2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.Image = global::PetAdoptionForm.Properties.Resources.icons8_back_50;
            this.btn_back.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_back.ImageRotate = 0F;
            this.btn_back.Location = new System.Drawing.Point(29, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.Size = new System.Drawing.Size(39, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sahiplendirilecek Hayvan Kayıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sahiplenme İsteği";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_accept;
        private Guna.UI2.WinForms.Guna2GradientButton btn_refuse;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Krypton.Toolkit.KryptonCheckedListBox list_requests;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Krypton.Toolkit.KryptonCheckedListBox list_request2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_accept2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_refuse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}