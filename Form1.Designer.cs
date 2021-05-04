namespace SpeedType
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
            this.components = new System.ComponentModel.Container();
            this.tmr_aparitieCuv = new System.Windows.Forms.Timer(this.components);
            this.tmr_acceleratie = new System.Windows.Forms.Timer(this.components);
            this.tmr_misca = new System.Windows.Forms.Timer(this.components);
            this.tmr_check = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr_aparitieCuv
            // 
            this.tmr_aparitieCuv.Enabled = true;
            this.tmr_aparitieCuv.Interval = 1000;
            this.tmr_aparitieCuv.Tick += new System.EventHandler(this.tmr_aparitieCuv_Tick);
            // 
            // tmr_acceleratie
            // 
            this.tmr_acceleratie.Enabled = true;
            this.tmr_acceleratie.Interval = 50000;
            this.tmr_acceleratie.Tick += new System.EventHandler(this.tmr_acceleratie_Tick);
            // 
            // tmr_misca
            // 
            this.tmr_misca.Enabled = true;
            this.tmr_misca.Tick += new System.EventHandler(this.tmr_misca_Tick);
            // 
            // tmr_check
            // 
            this.tmr_check.Enabled = true;
            this.tmr_check.Interval = 1;
            this.tmr_check.Tick += new System.EventHandler(this.tmr_check_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1259, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SpeedType";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_aparitieCuv;
        private System.Windows.Forms.Timer tmr_acceleratie;
        private System.Windows.Forms.Timer tmr_misca;
        private System.Windows.Forms.Timer tmr_check;
        private System.Windows.Forms.Label label1;
    }
}

