namespace WinReports
  {
  partial class ReportSetting
    {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose ( bool disposing )
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
    private void InitializeComponent ()
      {
      this.ddlRepotDesign = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblName = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtJobDesc = new System.Windows.Forms.TextBox();
      this.lblJobDesc = new System.Windows.Forms.Label();
      this.txtJob = new System.Windows.Forms.TextBox();
      this.lblJob = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtTotalSalary = new System.Windows.Forms.TextBox();
      this.lblTotalSalary = new System.Windows.Forms.Label();
      this.txtSalary = new System.Windows.Forms.TextBox();
      this.lblSalary = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.lblAddress = new System.Windows.Forms.Label();
      this.btnPrint = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // ddlRepotDesign
      // 
      this.ddlRepotDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlRepotDesign.FormattingEnabled = true;
      this.ddlRepotDesign.IntegralHeight = false;
      this.ddlRepotDesign.Items.AddRange(new object[] {
            "Defualt",
            "Dark",
            "Orange"});
      this.ddlRepotDesign.Location = new System.Drawing.Point(23, 12);
      this.ddlRepotDesign.Name = "ddlRepotDesign";
      this.ddlRepotDesign.Size = new System.Drawing.Size(614, 24);
      this.ddlRepotDesign.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtName);
      this.groupBox1.Controls.Add(this.lblName);
      this.groupBox1.Location = new System.Drawing.Point(23, 42);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(614, 88);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(9, 40);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(599, 24);
      this.txtName.TabIndex = 3;
      this.txtName.Text = "Muhammad Khair Albarmawi";
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(9, 20);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(43, 17);
      this.lblName.TabIndex = 3;
      this.lblName.Text = "Name";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtJobDesc);
      this.groupBox2.Controls.Add(this.lblJobDesc);
      this.groupBox2.Controls.Add(this.txtJob);
      this.groupBox2.Controls.Add(this.lblJob);
      this.groupBox2.Location = new System.Drawing.Point(23, 136);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(614, 141);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      // 
      // txtJobDesc
      // 
      this.txtJobDesc.Location = new System.Drawing.Point(9, 91);
      this.txtJobDesc.Name = "txtJobDesc";
      this.txtJobDesc.Size = new System.Drawing.Size(599, 24);
      this.txtJobDesc.TabIndex = 4;
      this.txtJobDesc.Text = "Web developer specialist ";
      // 
      // lblJobDesc
      // 
      this.lblJobDesc.AutoSize = true;
      this.lblJobDesc.Location = new System.Drawing.Point(9, 71);
      this.lblJobDesc.Name = "lblJobDesc";
      this.lblJobDesc.Size = new System.Drawing.Size(102, 17);
      this.lblJobDesc.TabIndex = 5;
      this.lblJobDesc.Text = "Job Description";
      // 
      // txtJob
      // 
      this.txtJob.Location = new System.Drawing.Point(9, 40);
      this.txtJob.Name = "txtJob";
      this.txtJob.Size = new System.Drawing.Size(599, 24);
      this.txtJob.TabIndex = 3;
      this.txtJob.Text = "Software Developer";
      // 
      // lblJob
      // 
      this.lblJob.AutoSize = true;
      this.lblJob.Location = new System.Drawing.Point(9, 20);
      this.lblJob.Name = "lblJob";
      this.lblJob.Size = new System.Drawing.Size(30, 17);
      this.lblJob.TabIndex = 3;
      this.lblJob.Text = "Job";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtTotalSalary);
      this.groupBox3.Controls.Add(this.lblTotalSalary);
      this.groupBox3.Controls.Add(this.txtSalary);
      this.groupBox3.Controls.Add(this.lblSalary);
      this.groupBox3.Location = new System.Drawing.Point(23, 283);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(614, 141);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      // 
      // txtTotalSalary
      // 
      this.txtTotalSalary.Location = new System.Drawing.Point(9, 91);
      this.txtTotalSalary.Name = "txtTotalSalary";
      this.txtTotalSalary.Size = new System.Drawing.Size(599, 24);
      this.txtTotalSalary.TabIndex = 4;
      this.txtTotalSalary.Text = "1100";
      // 
      // lblTotalSalary
      // 
      this.lblTotalSalary.AutoSize = true;
      this.lblTotalSalary.Location = new System.Drawing.Point(9, 71);
      this.lblTotalSalary.Name = "lblTotalSalary";
      this.lblTotalSalary.Size = new System.Drawing.Size(79, 17);
      this.lblTotalSalary.TabIndex = 5;
      this.lblTotalSalary.Text = "Total Salary";
      // 
      // txtSalary
      // 
      this.txtSalary.Location = new System.Drawing.Point(9, 40);
      this.txtSalary.Name = "txtSalary";
      this.txtSalary.Size = new System.Drawing.Size(599, 24);
      this.txtSalary.TabIndex = 3;
      this.txtSalary.Text = "1000";
      // 
      // lblSalary
      // 
      this.lblSalary.AutoSize = true;
      this.lblSalary.Location = new System.Drawing.Point(9, 20);
      this.lblSalary.Name = "lblSalary";
      this.lblSalary.Size = new System.Drawing.Size(79, 17);
      this.lblSalary.TabIndex = 3;
      this.lblSalary.Text = "Basic Salary";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.txtAddress);
      this.groupBox4.Controls.Add(this.lblAddress);
      this.groupBox4.Location = new System.Drawing.Point(23, 430);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(614, 80);
      this.groupBox4.TabIndex = 5;
      this.groupBox4.TabStop = false;
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(9, 40);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(599, 24);
      this.txtAddress.TabIndex = 3;
      this.txtAddress.Text = "Turkey , Istanbul, Eyüp , Alibeyköy Mahallesi.";
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(9, 20);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(56, 17);
      this.lblAddress.TabIndex = 3;
      this.lblAddress.Text = "Address";
      // 
      // btnPrint
      // 
      this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
      this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPrint.ForeColor = System.Drawing.Color.White;
      this.btnPrint.Location = new System.Drawing.Point(23, 530);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(614, 43);
      this.btnPrint.TabIndex = 6;
      this.btnPrint.Text = "Print Magic Report";
      this.btnPrint.UseVisualStyleBackColor = false;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // ReportSetting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(649, 592);
      this.Controls.Add(this.btnPrint);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ddlRepotDesign);
      this.Name = "ReportSetting";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Report Setting";
      this.Load += new System.EventHandler(this.ReportSetting_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.ComboBox ddlRepotDesign;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtJobDesc;
    private System.Windows.Forms.Label lblJobDesc;
    private System.Windows.Forms.TextBox txtJob;
    private System.Windows.Forms.Label lblJob;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox txtTotalSalary;
    private System.Windows.Forms.Label lblTotalSalary;
    private System.Windows.Forms.TextBox txtSalary;
    private System.Windows.Forms.Label lblSalary;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label lblAddress;
    private System.Windows.Forms.Button btnPrint;
    }
  }