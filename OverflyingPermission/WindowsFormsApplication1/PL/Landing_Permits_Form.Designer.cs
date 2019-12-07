namespace WindowsFormsApplication1.PL
{
    partial class Landing_Permits_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_Permits_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLandingSearch = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNmber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExitPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntryPoint = new System.Windows.Forms.TextBox();
            this.txtLPermitNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtLandingPerTime = new System.Windows.Forms.DateTimePicker();
            this.dtArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.cmbAirType = new System.Windows.Forms.ComboBox();
            this.txtAirReg = new System.Windows.Forms.TextBox();
            this.txtoprName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbByAny = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tbLandingID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLandingSearch)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(808, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 67);
            this.groupBox3.TabIndex = 189;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageKey = "cross.png";
            this.btnClose.Location = new System.Drawing.Point(354, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(83, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageKey = "arrow_refresh.png";
            this.btnEdit.Location = new System.Drawing.Point(181, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(81, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "cancel.png";
            this.btnDelete.Location = new System.Drawing.Point(268, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(80, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.ImageKey = "add.png";
            this.btnNew.Location = new System.Drawing.Point(13, 34);
            this.btnNew.Name = "btnNew";
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNew.Size = new System.Drawing.Size(80, 34);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLandingSearch);
            this.groupBox1.Location = new System.Drawing.Point(473, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 266);
            this.groupBox1.TabIndex = 190;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Landing Permits List:";
            // 
            // dgvLandingSearch
            // 
            this.dgvLandingSearch.AllowUserToAddRows = false;
            this.dgvLandingSearch.AllowUserToDeleteRows = false;
            this.dgvLandingSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLandingSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLandingSearch.Location = new System.Drawing.Point(12, 25);
            this.dgvLandingSearch.Name = "dgvLandingSearch";
            this.dgvLandingSearch.ReadOnly = true;
            this.dgvLandingSearch.Size = new System.Drawing.Size(543, 228);
            this.dgvLandingSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNmber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtExitPoint);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEntryPoint);
            this.groupBox2.Controls.Add(this.txtLPermitNo);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.dtLandingPerTime);
            this.groupBox2.Controls.Add(this.dtArrivalTime);
            this.groupBox2.Controls.Add(this.cmbAirType);
            this.groupBox2.Controls.Add(this.txtAirReg);
            this.groupBox2.Controls.Add(this.txtoprName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 348);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LandingPermitsInformation";
            // 
            // txtNmber
            // 
            this.txtNmber.BackColor = System.Drawing.SystemColors.Control;
            this.txtNmber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmber.Enabled = false;
            this.txtNmber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmber.ForeColor = System.Drawing.Color.Black;
            this.txtNmber.Location = new System.Drawing.Point(226, 19);
            this.txtNmber.Name = "txtNmber";
            this.txtNmber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNmber.Size = new System.Drawing.Size(240, 26);
            this.txtNmber.TabIndex = 206;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 205;
            this.label6.Text = "LandingPermitID";
            // 
            // txtExitPoint
            // 
            this.txtExitPoint.Location = new System.Drawing.Point(226, 239);
            this.txtExitPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtExitPoint.Name = "txtExitPoint";
            this.txtExitPoint.Size = new System.Drawing.Size(240, 20);
            this.txtExitPoint.TabIndex = 204;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 203;
            this.label4.Text = "Estimate Time Of Departure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 202;
            this.label5.Text = "Estimate Time Of Arrival";
            // 
            // txtEntryPoint
            // 
            this.txtEntryPoint.Location = new System.Drawing.Point(226, 200);
            this.txtEntryPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntryPoint.Name = "txtEntryPoint";
            this.txtEntryPoint.Size = new System.Drawing.Size(240, 20);
            this.txtEntryPoint.TabIndex = 201;
            // 
            // txtLPermitNo
            // 
            this.txtLPermitNo.Location = new System.Drawing.Point(226, 55);
            this.txtLPermitNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLPermitNo.Name = "txtLPermitNo";
            this.txtLPermitNo.Size = new System.Drawing.Size(240, 20);
            this.txtLPermitNo.TabIndex = 200;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 53);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 17);
            this.label20.TabIndex = 199;
            this.label20.Text = "LandingPermitNo";
            // 
            // dtLandingPerTime
            // 
            this.dtLandingPerTime.Location = new System.Drawing.Point(228, 316);
            this.dtLandingPerTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtLandingPerTime.Name = "dtLandingPerTime";
            this.dtLandingPerTime.Size = new System.Drawing.Size(240, 20);
            this.dtLandingPerTime.TabIndex = 198;
            // 
            // dtArrivalTime
            // 
            this.dtArrivalTime.Location = new System.Drawing.Point(228, 277);
            this.dtArrivalTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtArrivalTime.Name = "dtArrivalTime";
            this.dtArrivalTime.Size = new System.Drawing.Size(240, 20);
            this.dtArrivalTime.TabIndex = 197;
            // 
            // cmbAirType
            // 
            this.cmbAirType.FormattingEnabled = true;
            this.cmbAirType.Location = new System.Drawing.Point(226, 122);
            this.cmbAirType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAirType.Name = "cmbAirType";
            this.cmbAirType.Size = new System.Drawing.Size(240, 21);
            this.cmbAirType.TabIndex = 196;
            // 
            // txtAirReg
            // 
            this.txtAirReg.Location = new System.Drawing.Point(226, 162);
            this.txtAirReg.Margin = new System.Windows.Forms.Padding(2);
            this.txtAirReg.Name = "txtAirReg";
            this.txtAirReg.Size = new System.Drawing.Size(240, 20);
            this.txtAirReg.TabIndex = 195;
            // 
            // txtoprName
            // 
            this.txtoprName.Location = new System.Drawing.Point(226, 87);
            this.txtoprName.Margin = new System.Windows.Forms.Padding(2);
            this.txtoprName.Name = "txtoprName";
            this.txtoprName.Size = new System.Drawing.Size(240, 20);
            this.txtoprName.TabIndex = 194;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 193;
            this.label8.Text = "Exit Point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 192;
            this.label7.Text = "Entry Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 191;
            this.label3.Text = "AirCraft Regestration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 190;
            this.label2.Text = "Aircraft Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 189;
            this.label1.Text = "Operator Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbByAny);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnsearch);
            this.groupBox4.Controls.Add(this.tbLandingID);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(485, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 88);
            this.groupBox4.TabIndex = 206;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SearchSection:";
            // 
            // tbByAny
            // 
            this.tbByAny.Location = new System.Drawing.Point(144, 57);
            this.tbByAny.Name = "tbByAny";
            this.tbByAny.Size = new System.Drawing.Size(173, 21);
            this.tbByAny.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Just Search";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Black;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(337, 32);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(106, 30);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // tbLandingID
            // 
            this.tbLandingID.Location = new System.Drawing.Point(144, 32);
            this.tbLandingID.Name = "tbLandingID";
            this.tbLandingID.Size = new System.Drawing.Size(173, 21);
            this.tbLandingID.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Landing Permit ID :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageKey = "arrow_refresh.png";
            this.btnAdd.Location = new System.Drawing.Point(95, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(81, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // Landing_Permits_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 455);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Landing_Permits_Form";
            this.Text = "Landing_Permits_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLandingSearch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLandingSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNmber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExitPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntryPoint;
        private System.Windows.Forms.TextBox txtLPermitNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtLandingPerTime;
        private System.Windows.Forms.DateTimePicker dtArrivalTime;
        private System.Windows.Forms.ComboBox cmbAirType;
        private System.Windows.Forms.TextBox txtAirReg;
        private System.Windows.Forms.TextBox txtoprName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbByAny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tbLandingID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
    }
}