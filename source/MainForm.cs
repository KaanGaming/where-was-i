using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WhereWasI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnAboutLocation_Click(object sender, EventArgs e)
		{
			DialogResult areYouSure = MessageBox.Show("This will take you to the google from chrome searching about this location. Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(areYouSure == DialogResult.Yes)
			{
				Process chrome = new Process();
				chrome.StartInfo.FileName = "chrome";
				string arguments = "\"https://maps.google.com/maps?q=" + PinnedLocations.SelectedItem.ToString() + "\"";
				chrome.StartInfo.Arguments = arguments;
				chrome.Start();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (!File.Exists("pins.txt")) File.Create("pins.txt");
			txtAbout.Text = "About: This is an app that saves your pinned locations. You can learn anything about them, add some, and remove some.";
			foreach(string value in File.ReadAllLines("pins.txt"))
			{
				PinnedLocations.Items.Add(value);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			/* Starts the form AddDialouge,
			   Checks if the dialouge result is OK,
			   If it's OK, then add the value. */

			DialogResult dialog = (new AddDialouge()).ShowDialog();
			if (Variables.LatestResult == DialogResult.OK)
			{
				PinnedLocations.Items.Add(Variables.LatestAddedLocation.ToString());
				if(File.ReadAllText("pins.txt") != "")
				{
					// If it's not empty, append a new value.
					File.AppendAllText("pins.txt", "\n" + Variables.LatestAddedLocation);
		        } else
				{
					// If it's empty, create new one.
					File.WriteAllText("pins.txt", Variables.LatestAddedLocation);
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (PinnedLocations.SelectedItem != null)
			{
				// Remove the selected item.
				PinnedLocations.Items.RemoveAt(PinnedLocations.SelectedIndex);
				File.WriteAllText("pins.txt", "");
				File.WriteAllLines("pins.txt", PinnedLocations.Items.OfType<string>().ToArray());
			}
		}
	}
}
