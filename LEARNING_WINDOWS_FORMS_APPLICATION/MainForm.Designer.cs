namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.components = new System.ComponentModel.Container();
			this.labelCaption = new System.Windows.Forms.Label();
			this.labelTimer = new System.Windows.Forms.Timer(this.components);
			this.formTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// labelCaption
			// 
			this.labelCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCaption.BackColor = System.Drawing.Color.Khaki;
			this.labelCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCaption.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelCaption.Location = new System.Drawing.Point(12, 9);
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.Size = new System.Drawing.Size(96, 318);
			this.labelCaption.TabIndex = 0;
			this.labelCaption.Text = "به کلاس من خوش آمدید";
			this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTimer
			// 
			this.labelTimer.Enabled = true;
			this.labelTimer.Interval = 1000;
			this.labelTimer.Tick += new System.EventHandler(this.LabelTimer_Tick);
			// 
			// formTimer
			// 
			this.formTimer.Enabled = true;
			this.formTimer.Interval = 1;
			this.formTimer.Tick += new System.EventHandler(this.FormTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(120, 336);
			this.Controls.Add(this.labelCaption);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelCaption;
		private System.Windows.Forms.Timer labelTimer;
		private System.Windows.Forms.Timer formTimer;
	}
}
