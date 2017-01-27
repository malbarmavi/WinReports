using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinReports
  {
  public partial class WinReports : Form
    {
    public WinReports ()
      {
      InitializeComponent();

      }

    private void WinReports_Load ( object sender, EventArgs e )
      {

      }

    private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
      {
      MessageBox.Show("Report Magic \nMuhammad Khair Albarmawi", "Magic Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
  }
