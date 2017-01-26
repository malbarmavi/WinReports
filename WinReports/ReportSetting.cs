using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinReports
  {
  public partial class ReportSetting : Form
    {
    public ReportSetting ()
      {
      InitializeComponent();
      }

    private void ReportSetting_Load ( object sender, EventArgs e )
      {
      ddlRepotDesign.SelectedIndex = 0;
      }

    private void btnPrint_Click ( object sender, EventArgs e )
      {
      var winPrint = new WinReports();
      var reportString = new StringBuilder();

      reportString.Append(File.ReadAllText($@"Reports\{ddlRepotDesign.Text}.html"));
      reportString
        .Replace("$header", "Report Magic ")
        .Replace("$name", txtName.Text)
        .Replace("$job", txtJob.Text)
        .Replace("$job-desc", txtJobDesc.Text)
        .Replace("$salary", txtSalary.Text)
        .Replace("$total-salary", txtTotalSalary.Text)
        .Replace("$address", txtAddress.Text);

      winPrint.WebView.DocumentText = reportString.ToString();
      winPrint.Show();
      }
    }
  }
