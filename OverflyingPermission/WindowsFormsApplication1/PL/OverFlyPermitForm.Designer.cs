namespace WindowsFormsApplication1.PL
{
    partial class OverFlyPermitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverFlyPermitForm));
            this.label11 = new System.Windows.Forms.Label();
            this.txtOverFlyID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtTakeOffTime = new System.Windows.Forms.DateTimePicker();
            this.dtTakeOffArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.cmbOverFlyAirType = new System.Windows.Forms.ComboBox();
            this.txtOverFlyAirReg = new System.Windows.Forms.TextBox();
            this.txtOverFlyOprName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBillingAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTakeOffPurpose = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOverFlyExitPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOverFlyEntryPoint = new System.Windows.Forms.TextBox();
            this.txtOverFlyNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOverFlySearch = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbOverFlyID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbByAny = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverFlySearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 353);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 207;
            this.label11.Text = "Purpose";
            // 
            // txtOverFlyID
            // 
            this.txtOverFlyID.Location = new System.Drawing.Point(226, 20);
            this.txtOverFlyID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOverFlyID.Name = "txtOverFlyID";
            this.txtOverFlyID.Size = new System.Drawing.Size(240, 20);
            this.txtOverFlyID.TabIndex = 206;
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
            this.btnDelete.ForeColor = System.Drawing.Color.White;
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
            // dtTakeOffTime
            // 
            this.dtTakeOffTime.Location = new System.Drawing.Point(226, 316);
            this.dtTakeOffTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtTakeOffTime.Name = "dtTakeOffTime";
            this.dtTakeOffTime.Size = new System.Drawing.Size(240, 20);
            this.dtTakeOffTime.TabIndex = 198;
            // 
            // dtTakeOffArrivalTime
            // 
            this.dtTakeOffArrivalTime.Location = new System.Drawing.Point(226, 277);
            this.dtTakeOffArrivalTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtTakeOffArrivalTime.Name = "dtTakeOffArrivalTime";
            this.dtTakeOffArrivalTime.Size = new System.Drawing.Size(240, 20);
            this.dtTakeOffArrivalTime.TabIndex = 197;
            // 
            // cmbOverFlyAirType
            // 
            this.cmbOverFlyAirType.FormattingEnabled = true;
            this.cmbOverFlyAirType.Location = new System.Drawing.Point(226, 122);
            this.cmbOverFlyAirType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOverFlyAirType.Name = "cmbOverFlyAirType";
            this.cmbOverFlyAirType.Size = new System.Drawing.Size(240, 21);
            this.cmbOverFlyAirType.TabIndex = 196;
            // 
            // txtOverFlyAirReg
            // 
            this.txtOverFlyAirReg.Location = new System.Drawing.Point(226, 162);
            this.txtOverFlyAirReg.Margin = new System.Windows.Forms.Padding(2);
            this.txtOverFlyAirReg.Name = "txtOverFlyAirReg";
            this.txtOverFlyAirReg.Size = new System.Drawing.Size(240, 20);
            this.txtOverFlyAirReg.TabIndex = 195;
            // 
            // txtOverFlyOprName
            // 
            this.txtOverFlyOprName.Location = new System.Drawing.Point(226, 87);
            this.txtOverFlyOprName.Margin = new System.Windows.Forms.Padding(2);
            this.txtOverFlyOprName.Name = "txtOverFlyOprName";
            this.txtOverFlyOprName.Size = new System.Drawing.Size(240, 20);
            this.txtOverFlyOprName.TabIndex = 194;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFlightNumber);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtBillingAddress);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTakeOffPurpose);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtOverFlyID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOverFlyExitPoint);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOverFlyEntryPoint);
            this.groupBox2.Controls.Add(this.txtOverFlyNumber);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.dtTakeOffTime);
            this.groupBox2.Controls.Add(this.dtTakeOffArrivalTime);
            this.groupBox2.Controls.Add(this.cmbOverFlyAirType);
            this.groupBox2.Controls.Add(this.txtOverFlyAirReg);
            this.groupBox2.Controls.Add(this.txtOverFlyOprName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 433);
            this.groupBox2.TabIndex = 212;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OverFlyPermitInfo";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(226, 413);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(240, 20);
            this.txtFlightNumber.TabIndex = 212;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 413);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 211;
            this.label13.Text = "FlightNumber";
            // 
            // txtBillingAddress
            // 
            this.txtBillingAddress.Location = new System.Drawing.Point(226, 387);
            this.txtBillingAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillingAddress.Name = "txtBillingAddress";
            this.txtBillingAddress.Size = new System.Drawing.Size(240, 20);
            this.txtBillingAddress.TabIndex = 210;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 385);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 209;
            this.label12.Text = "BillingAddress";
            // 
            // txtTakeOffPurpose
            // 
            this.txtTakeOffPurpose.Location = new System.Drawing.Point(226, 353);
            this.txtTakeOffPurpose.Margin = new System.Windows.Forms.Padding(2);
            this.txtTakeOffPurpose.Name = "txtTakeOffPurpose";
            this.txtTakeOffPurpose.Size = new System.Drawing.Size(240, 20);
            this.txtTakeOffPurpose.TabIndex = 208;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 205;
            this.label6.Text = "OverFlyID";
            // 
            // txtOverFlyExitPoint
            // 
            this.txtOverFlyExitPoint.Location = new System.Drawing.Point(226, 239);
            this.txtOverFlyExitPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtOverFlyExitPoint.Name = "txtOverFlyExitPoint";
            this.txtOverFlyExitPoint.Size = new System.Drawing.Size(240, 20);
            this.txtOverFlyExitPoint.TabIndex = 204;
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
            // txtOverFlyEntryPoint
            // 
            this.txtOverFlyEntryPoint.Location = new System.Drawing.Point(226, 200);
            this.txtOverFlyEntryPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtOverFlyEntryPoint.Name = "txtOverFlyEntryPoint";
            this.txtOverFlyEntryPoint.Size = new System.Drawing.Size(240, 20);
            this.txtOverFlyEntryPoint.TabIndex = 201;
            // 
            // txtOverFlyNumber
            // 
            this.txtOverFlyNumber.Location = new System.Drawing.Point(226, 55);
            this.txtOverFlyNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtOverFlyNumber.Name = "txtOverFlyNumber";
            this.txtOverFlyNumber.Size = new System.Drawing.Size(240, 20);
            this.txtOverFlyNumber.TabIndex = 200;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 53);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 17);
            this.label20.TabIndex = 199;
            this.label20.Text = "OverFlyNumber";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOverFlySearch);
            this.groupBox1.Location = new System.Drawing.Point(474, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 266);
            this.groupBox1.TabIndex = 215;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OverFlyPermitInfoList:";
            // 
            // dgvOverFlySearch
            // 
            this.dgvOverFlySearch.AllowUserToAddRows = false;
            this.dgvOverFlySearch.AllowUserToDeleteRows = false;
            this.dgvOverFlySearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverFlySearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverFlySearch.Location = new System.Drawing.Point(12, 25);
            this.dgvOverFlySearch.Name = "dgvOverFlySearch";
            this.dgvOverFlySearch.ReadOnly = true;
            this.dgvOverFlySearch.Size = new System.Drawing.Size(543, 228);
            this.dgvOverFlySearch.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(809, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 213;
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
            this.groupBox3.Location = new System.Drawing.Point(17, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 67);
            this.groupBox3.TabIndex = 214;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageKey = "arrow_refresh.png";
            this.btnAdd.Location = new System.Drawing.Point(97, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(81, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbOverFlyID
            // 
            this.tbOverFlyID.Location = new System.Drawing.Point(144, 32);
            this.tbOverFlyID.Name = "tbOverFlyID";
            this.tbOverFlyID.Size = new System.Drawing.Size(173, 21);
            this.tbOverFlyID.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbByAny);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnsearch);
            this.groupBox4.Controls.Add(this.tbOverFlyID);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(486, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 88);
            this.groupBox4.TabIndex = 216;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "OverFlyID:";
            // 
            // OverFlyPermitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "OverFlyPermitForm";
            this.Text = "OverFlyPermitForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverFlySearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOverFlyID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtTakeOffTime;
        private System.Windows.Forms.DateTimePicker dtTakeOffArrivalTime;
        private System.Windows.Forms.ComboBox cmbOverFlyAirType;
        private System.Windows.Forms.TextBox txtOverFlyAirReg;
        private System.Windows.Forms.TextBox txtOverFlyOprName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTakeOffPurpose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOverFlyExitPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOverFlyEntryPoint;
        private System.Windows.Forms.TextBox txtOverFlyNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOverFlySearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbOverFlyID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbByAny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBillingAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
    }
}