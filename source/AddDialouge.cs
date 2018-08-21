using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereWasI
{
	public partial class AddDialouge : Form
	{
		public AddDialouge()
		{
			InitializeComponent();
		}

		// Avoid confusion in AddDialouge_FormClosing.
		bool ClickedOK = false;

		private void btnOK_Click(object sender, EventArgs e)
		{
			Variables.LatestAddedLocation = txtName.Text;
			Variables.LatestResult = DialogResult.OK;
			ClickedOK = true;
			Close();
		}

		private void AddDialouge_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(!ClickedOK)
			{
				// Ask the user if he wants to quit with unsaved changes.
				DialogResult areYouSureToQuit = MessageBox.Show("Are you sure to don't save?", "", MessageBoxButtons.YesNo);
				if (areYouSureToQuit == DialogResult.No) { e.Cancel = true; } else
				{
					Variables.LatestResult = DialogResult.Cancel;
				}
			}
		}
	}
}
