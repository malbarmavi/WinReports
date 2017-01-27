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
      if (!chkFillWidth.Checked)
        {
        reportString.Append(File.ReadAllText($@"Reports\{ddlRepotDesign.Text}.html"));
        reportString
          .Replace("$header", "Magic Report")
          .Replace("$name", txtName.Text)
          .Replace("$job", txtJob.Text)
          .Replace("$job-desc", txtJobDesc.Text)
          .Replace("$salary", txtSalary.Text)
          .Replace("$total-salary", txtTotalSalary.Text)
          .Replace("$address", txtAddress.Text);
        } else
        {
        reportString.Append(File.ReadAllText($@"Reports\full_width.html"));
        var reportData = new StringBuilder();
        for (int i = 0; i < 5000 ; i++)
          {
          reportData.Append($"<tr><td>{i}</td><td>Muhammad Khair {i}</td><td>Developer{i*2}</td><td>Syria - daraa {i}</td><td>{Convert.ToDouble(i).ToString("###,###")}</td><td>Turkey {i}</td><td>Istanbul {i}</td><td>TRY {i}</td></tr>");
          }
        reportString.Replace("$tr-data", reportData.ToString());
        }
      winPrint.WebView.DocumentText = reportString.ToString();
      winPrint.WebView.ScrollBarsEnabled = true;
      winPrint.Show();
      }

    private void chkFillWidth_Click ( object sender, EventArgs e )
      {
      ddlRepotDesign.Enabled = groupBox1.Enabled = groupBox2.Enabled =
        groupBox3.Enabled = groupBox4.Enabled = !chkFillWidth.Checked;
      }
    }
  }
