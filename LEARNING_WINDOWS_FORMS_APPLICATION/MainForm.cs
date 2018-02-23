namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void labelTimer_Tick(object sender, System.EventArgs e)
		{
			//if (labelCaption.Text == "به کلاس من خوش آمدید")
			//{
			//	labelCaption.Text = "ارادتمند شما داریوش تصدیقی";
			//}
			//else
			//{
			//	labelCaption.Text = "به کلاس من خوش آمدید";
			//}

			if (string.Compare(labelCaption.Text, "به کلاس من خوش آمدید", ignoreCase: true) == 0)
			{
				labelCaption.Text = "ارادتمند شما داریوش تصدیقی";
			}
			else
			{
				labelCaption.Text = "به کلاس من خوش آمدید";
			}
		}

		private void formTimer_Tick(object sender, System.EventArgs e)
		{
			if (Width < 560)
			{
				Width += 6;
			}
			else
			{
				formTimer.Enabled = false;
			}
		}
	}
}
