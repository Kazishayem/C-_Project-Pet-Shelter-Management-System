namespace Pet_Shelter_Management_System
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
            this.myProgress = new MetroFramework.Controls.MetroProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myProgress
            // 
            this.myProgress.Location = new System.Drawing.Point(-1, 152);
            this.myProgress.Margin = new System.Windows.Forms.Padding(4);
            this.myProgress.Name = "myProgress";
            this.myProgress.Size = new System.Drawing.Size(343, 10);
            this.myProgress.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pet Shelter Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myProgress);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 37, 30, 25);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar myProgress;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}

