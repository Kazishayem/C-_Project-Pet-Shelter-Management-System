namespace Pet_Shelter_Management_System
{
    partial class Dashboard
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnFillClear = new MetroFramework.Controls.MetroButton();
            this.btnSeeAvailablePets = new MetroFramework.Controls.MetroButton();
            this.dgvSeePetDetail = new System.Windows.Forms.DataGridView();
            this.btnFillOutRequest = new MetroFramework.Controls.MetroButton();
            this.cmbFillOutFoster = new MetroFramework.Controls.MetroComboBox();
            this.cmbFillOutCatagory = new MetroFramework.Controls.MetroComboBox();
            this.txtFillOutType = new MetroFramework.Controls.MetroTextBox();
            this.txtFillOutPetID = new MetroFramework.Controls.MetroTextBox();
            this.txtFilloutUserID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSearchAv = new MetroFramework.Controls.MetroButton();
            this.txtLookigFor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbSelectCatagory = new MetroFramework.Controls.MetroComboBox();
            this.btnDashboardLogout = new MetroFramework.Controls.MetroButton();
            this.petid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pettype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petcatagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeePetDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDashboardLogout);
            this.metroPanel1.Controls.Add(this.btnFillClear);
            this.metroPanel1.Controls.Add(this.btnSeeAvailablePets);
            this.metroPanel1.Controls.Add(this.dgvSeePetDetail);
            this.metroPanel1.Controls.Add(this.btnFillOutRequest);
            this.metroPanel1.Controls.Add(this.cmbFillOutFoster);
            this.metroPanel1.Controls.Add(this.cmbFillOutCatagory);
            this.metroPanel1.Controls.Add(this.txtFillOutType);
            this.metroPanel1.Controls.Add(this.txtFillOutPetID);
            this.metroPanel1.Controls.Add(this.txtFilloutUserID);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btnSearchAv);
            this.metroPanel1.Controls.Add(this.txtLookigFor);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.cmbSelectCatagory);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(734, 431);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnFillClear
            // 
            this.btnFillClear.Location = new System.Drawing.Point(610, 223);
            this.btnFillClear.Name = "btnFillClear";
            this.btnFillClear.Size = new System.Drawing.Size(102, 23);
            this.btnFillClear.TabIndex = 22;
            this.btnFillClear.Text = "Clear";
            this.btnFillClear.UseSelectable = true;
            this.btnFillClear.Click += new System.EventHandler(this.btnFillClear_Click);
            // 
            // btnSeeAvailablePets
            // 
            this.btnSeeAvailablePets.Location = new System.Drawing.Point(17, 223);
            this.btnSeeAvailablePets.Name = "btnSeeAvailablePets";
            this.btnSeeAvailablePets.Size = new System.Drawing.Size(127, 23);
            this.btnSeeAvailablePets.TabIndex = 21;
            this.btnSeeAvailablePets.Text = "See Available Pets";
            this.btnSeeAvailablePets.UseSelectable = true;
            this.btnSeeAvailablePets.Click += new System.EventHandler(this.btnSeeAvailablePets_Click);
            // 
            // dgvSeePetDetail
            // 
            this.dgvSeePetDetail.AllowUserToAddRows = false;
            this.dgvSeePetDetail.AllowUserToDeleteRows = false;
            this.dgvSeePetDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeePetDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petid,
            this.pettype,
            this.petage,
            this.weight,
            this.color,
            this.petcatagory});
            this.dgvSeePetDetail.Location = new System.Drawing.Point(0, 252);
            this.dgvSeePetDetail.Name = "dgvSeePetDetail";
            this.dgvSeePetDetail.ReadOnly = true;
            this.dgvSeePetDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeePetDetail.Size = new System.Drawing.Size(734, 199);
            this.dgvSeePetDetail.TabIndex = 19;
            // 
            // btnFillOutRequest
            // 
            this.btnFillOutRequest.Location = new System.Drawing.Point(483, 223);
            this.btnFillOutRequest.Name = "btnFillOutRequest";
            this.btnFillOutRequest.Size = new System.Drawing.Size(106, 23);
            this.btnFillOutRequest.TabIndex = 18;
            this.btnFillOutRequest.Text = "Request";
            this.btnFillOutRequest.UseSelectable = true;
            this.btnFillOutRequest.Click += new System.EventHandler(this.btnFillOutRequest_Click);
            // 
            // cmbFillOutFoster
            // 
            this.cmbFillOutFoster.FormattingEnabled = true;
            this.cmbFillOutFoster.ItemHeight = 23;
            this.cmbFillOutFoster.Items.AddRange(new object[] {
            "15 days",
            "30 days",
            "45 days"});
            this.cmbFillOutFoster.Location = new System.Drawing.Point(591, 188);
            this.cmbFillOutFoster.Name = "cmbFillOutFoster";
            this.cmbFillOutFoster.Size = new System.Drawing.Size(121, 29);
            this.cmbFillOutFoster.TabIndex = 17;
            this.cmbFillOutFoster.UseSelectable = true;
            // 
            // cmbFillOutCatagory
            // 
            this.cmbFillOutCatagory.FormattingEnabled = true;
            this.cmbFillOutCatagory.ItemHeight = 23;
            this.cmbFillOutCatagory.Items.AddRange(new object[] {
            "adoption",
            "foster",
            "return rescued pet"});
            this.cmbFillOutCatagory.Location = new System.Drawing.Point(591, 153);
            this.cmbFillOutCatagory.Name = "cmbFillOutCatagory";
            this.cmbFillOutCatagory.Size = new System.Drawing.Size(121, 29);
            this.cmbFillOutCatagory.TabIndex = 16;
            this.cmbFillOutCatagory.UseSelectable = true;
            // 
            // txtFillOutType
            // 
            // 
            // 
            // 
            this.txtFillOutType.CustomButton.Image = null;
            this.txtFillOutType.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtFillOutType.CustomButton.Name = "";
            this.txtFillOutType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFillOutType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFillOutType.CustomButton.TabIndex = 1;
            this.txtFillOutType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFillOutType.CustomButton.UseSelectable = true;
            this.txtFillOutType.CustomButton.Visible = false;
            this.txtFillOutType.Lines = new string[0];
            this.txtFillOutType.Location = new System.Drawing.Point(591, 121);
            this.txtFillOutType.MaxLength = 32767;
            this.txtFillOutType.Name = "txtFillOutType";
            this.txtFillOutType.PasswordChar = '\0';
            this.txtFillOutType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFillOutType.SelectedText = "";
            this.txtFillOutType.SelectionLength = 0;
            this.txtFillOutType.SelectionStart = 0;
            this.txtFillOutType.ShortcutsEnabled = true;
            this.txtFillOutType.Size = new System.Drawing.Size(121, 23);
            this.txtFillOutType.TabIndex = 15;
            this.txtFillOutType.UseSelectable = true;
            this.txtFillOutType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFillOutType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFillOutPetID
            // 
            // 
            // 
            // 
            this.txtFillOutPetID.CustomButton.Image = null;
            this.txtFillOutPetID.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtFillOutPetID.CustomButton.Name = "";
            this.txtFillOutPetID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFillOutPetID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFillOutPetID.CustomButton.TabIndex = 1;
            this.txtFillOutPetID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFillOutPetID.CustomButton.UseSelectable = true;
            this.txtFillOutPetID.CustomButton.Visible = false;
            this.txtFillOutPetID.Lines = new string[0];
            this.txtFillOutPetID.Location = new System.Drawing.Point(591, 89);
            this.txtFillOutPetID.MaxLength = 32767;
            this.txtFillOutPetID.Name = "txtFillOutPetID";
            this.txtFillOutPetID.PasswordChar = '\0';
            this.txtFillOutPetID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFillOutPetID.SelectedText = "";
            this.txtFillOutPetID.SelectionLength = 0;
            this.txtFillOutPetID.SelectionStart = 0;
            this.txtFillOutPetID.ShortcutsEnabled = true;
            this.txtFillOutPetID.Size = new System.Drawing.Size(121, 23);
            this.txtFillOutPetID.TabIndex = 14;
            this.txtFillOutPetID.UseSelectable = true;
            this.txtFillOutPetID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFillOutPetID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFilloutUserID
            // 
            // 
            // 
            // 
            this.txtFilloutUserID.CustomButton.Image = null;
            this.txtFilloutUserID.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtFilloutUserID.CustomButton.Name = "";
            this.txtFilloutUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilloutUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilloutUserID.CustomButton.TabIndex = 1;
            this.txtFilloutUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilloutUserID.CustomButton.UseSelectable = true;
            this.txtFilloutUserID.CustomButton.Visible = false;
            this.txtFilloutUserID.Lines = new string[0];
            this.txtFilloutUserID.Location = new System.Drawing.Point(591, 60);
            this.txtFilloutUserID.MaxLength = 32767;
            this.txtFilloutUserID.Name = "txtFilloutUserID";
            this.txtFilloutUserID.PasswordChar = '\0';
            this.txtFilloutUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilloutUserID.SelectedText = "";
            this.txtFilloutUserID.SelectionLength = 0;
            this.txtFilloutUserID.SelectionStart = 0;
            this.txtFilloutUserID.ShortcutsEnabled = true;
            this.txtFilloutUserID.Size = new System.Drawing.Size(121, 23);
            this.txtFilloutUserID.TabIndex = 13;
            this.txtFilloutUserID.UseSelectable = true;
            this.txtFilloutUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilloutUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(417, 188);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(157, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Foster Days(If Applicable)";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(417, 157);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Category";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(417, 125);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Pet Type";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(417, 89);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Pet ID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(417, 59);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "User ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(417, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(150, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Fillout Information";
            // 
            // btnSearchAv
            // 
            this.btnSearchAv.Location = new System.Drawing.Point(134, 110);
            this.btnSearchAv.Name = "btnSearchAv";
            this.btnSearchAv.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAv.TabIndex = 6;
            this.btnSearchAv.Text = "Search";
            this.btnSearchAv.UseSelectable = true;
            this.btnSearchAv.Click += new System.EventHandler(this.btnSearchAv_Click);
            // 
            // txtLookigFor
            // 
            // 
            // 
            // 
            this.txtLookigFor.CustomButton.Image = null;
            this.txtLookigFor.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtLookigFor.CustomButton.Name = "";
            this.txtLookigFor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLookigFor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLookigFor.CustomButton.TabIndex = 1;
            this.txtLookigFor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLookigFor.CustomButton.UseSelectable = true;
            this.txtLookigFor.CustomButton.Visible = false;
            this.txtLookigFor.Lines = new string[0];
            this.txtLookigFor.Location = new System.Drawing.Point(134, 16);
            this.txtLookigFor.MaxLength = 32767;
            this.txtLookigFor.Name = "txtLookigFor";
            this.txtLookigFor.PasswordChar = '\0';
            this.txtLookigFor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLookigFor.SelectedText = "";
            this.txtLookigFor.SelectionLength = 0;
            this.txtLookigFor.SelectionStart = 0;
            this.txtLookigFor.ShortcutsEnabled = true;
            this.txtLookigFor.Size = new System.Drawing.Size(113, 23);
            this.txtLookigFor.TabIndex = 5;
            this.txtLookigFor.UseSelectable = true;
            this.txtLookigFor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLookigFor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "I Am Looking For";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Select Category";
            // 
            // cmbSelectCatagory
            // 
            this.cmbSelectCatagory.FormattingEnabled = true;
            this.cmbSelectCatagory.ItemHeight = 23;
            this.cmbSelectCatagory.Items.AddRange(new object[] {
            "adoption",
            "foster"});
            this.cmbSelectCatagory.Location = new System.Drawing.Point(134, 60);
            this.cmbSelectCatagory.Name = "cmbSelectCatagory";
            this.cmbSelectCatagory.Size = new System.Drawing.Size(113, 29);
            this.cmbSelectCatagory.TabIndex = 2;
            this.cmbSelectCatagory.UseSelectable = true;
            // 
            // btnDashboardLogout
            // 
            this.btnDashboardLogout.Location = new System.Drawing.Point(637, 3);
            this.btnDashboardLogout.Name = "btnDashboardLogout";
            this.btnDashboardLogout.Size = new System.Drawing.Size(75, 23);
            this.btnDashboardLogout.TabIndex = 23;
            this.btnDashboardLogout.Text = "LOGOUT";
            this.btnDashboardLogout.UseSelectable = true;
            this.btnDashboardLogout.Click += new System.EventHandler(this.btnDashboardLogout_Click);
            // 
            // petid
            // 
            this.petid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.petid.DataPropertyName = "petid";
            this.petid.HeaderText = "Pet ID";
            this.petid.Name = "petid";
            this.petid.ReadOnly = true;
            // 
            // pettype
            // 
            this.pettype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pettype.DataPropertyName = "pettype";
            this.pettype.HeaderText = "Pet Type";
            this.pettype.Name = "pettype";
            this.pettype.ReadOnly = true;
            // 
            // petage
            // 
            this.petage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.petage.DataPropertyName = "petage";
            this.petage.HeaderText = "Age";
            this.petage.Name = "petage";
            this.petage.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // petcatagory
            // 
            this.petcatagory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.petcatagory.DataPropertyName = "petcatagory";
            this.petcatagory.HeaderText = "Pet Category";
            this.petcatagory.Name = "petcatagory";
            this.petcatagory.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.metroPanel1);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeePetDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSearchAv;
        private MetroFramework.Controls.MetroTextBox txtLookigFor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbSelectCatagory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnFillOutRequest;
        private MetroFramework.Controls.MetroComboBox cmbFillOutFoster;
        private MetroFramework.Controls.MetroComboBox cmbFillOutCatagory;
        private MetroFramework.Controls.MetroTextBox txtFillOutType;
        private MetroFramework.Controls.MetroTextBox txtFillOutPetID;
        private MetroFramework.Controls.MetroTextBox txtFilloutUserID;
        private System.Windows.Forms.DataGridView dgvSeePetDetail;
        private MetroFramework.Controls.MetroButton btnSeeAvailablePets;
        private MetroFramework.Controls.MetroButton btnFillClear;
        private MetroFramework.Controls.MetroButton btnDashboardLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn petid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pettype;
        private System.Windows.Forms.DataGridViewTextBoxColumn petage;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn petcatagory;
    }
}