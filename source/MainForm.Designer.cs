namespace WhereWasI
{
	partial class MainForm
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.PinnedLocations = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAboutLocation = new System.Windows.Forms.Button();
			this.txtAbout = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// PinnedLocations
			// 
			this.PinnedLocations.FormattingEnabled = true;
			this.PinnedLocations.Location = new System.Drawing.Point(12, 12);
			this.PinnedLocations.Name = "PinnedLocations";
			this.PinnedLocations.Size = new System.Drawing.Size(187, 251);
			this.PinnedLocations.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(205, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(131, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add...";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(205, 41);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(131, 23);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Remove...";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAboutLocation
			// 
			this.btnAboutLocation.Location = new System.Drawing.Point(205, 70);
			this.btnAboutLocation.Name = "btnAboutLocation";
			this.btnAboutLocation.Size = new System.Drawing.Size(131, 23);
			this.btnAboutLocation.TabIndex = 3;
			this.btnAboutLocation.Text = "About this location...";
			this.btnAboutLocation.UseVisualStyleBackColor = true;
			this.btnAboutLocation.Click += new System.EventHandler(this.btnAboutLocation_Click);
			// 
			// txtAbout
			// 
			this.txtAbout.Location = new System.Drawing.Point(342, 12);
			this.txtAbout.Multiline = true;
			this.txtAbout.Name = "txtAbout";
			this.txtAbout.ReadOnly = true;
			this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtAbout.Size = new System.Drawing.Size(233, 246);
			this.txtAbout.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 270);
			this.Controls.Add(this.txtAbout);
			this.Controls.Add(this.btnAboutLocation);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.PinnedLocations);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Where was I? - Pinned locations";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox PinnedLocations;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAboutLocation;
		private System.Windows.Forms.TextBox txtAbout;
	}
}

