namespace NetLimDisable
{
	partial class TriggerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerForm));
			this.netLimDisable = new System.Windows.Forms.CheckBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.aboutButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// netLimDisable
			// 
			this.netLimDisable.AutoSize = true;
			this.netLimDisable.ForeColor = System.Drawing.Color.White;
			this.netLimDisable.Location = new System.Drawing.Point(15, 15);
			this.netLimDisable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.netLimDisable.Name = "netLimDisable";
			this.netLimDisable.Size = new System.Drawing.Size(385, 19);
			this.netLimDisable.TabIndex = 0;
			this.netLimDisable.Text = "Disable internet AutoConfig limit checker (disable BadStateTracking)";
			this.netLimDisable.UseVisualStyleBackColor = true;
			// 
			// applyButton
			// 
			this.applyButton.Location = new System.Drawing.Point(441, 40);
			this.applyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(88, 27);
			this.applyButton.TabIndex = 1;
			this.applyButton.Text = "Apply";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// aboutButton
			// 
			this.aboutButton.Location = new System.Drawing.Point(345, 40);
			this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(88, 27);
			this.aboutButton.TabIndex = 2;
			this.aboutButton.Text = "About...";
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// TriggerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(542, 81);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.applyButton);
			this.Controls.Add(this.netLimDisable);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TriggerForm";
			this.Text = "Internet AutoConfig Limit Check Disabler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox netLimDisable;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Button aboutButton;
	}
}

