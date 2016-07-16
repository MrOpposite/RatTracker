using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Windows.Interop;
using System.Runtime.InteropServices;

namespace RatTracker_WPF.DispatchInterface
{
	/// <summary>
	/// Interaction logic for DispatchMain.xaml
	/// </summary>
	public partial class DispatchMain : Window
	{
		public DispatchMain()
		{
			InitializeComponent();

		}

		private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
		{
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
		}

		private void GainFocus(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("GainFocus");
			Activate();
		}

		private void LooseFocus(object sender, RoutedEventArgs e)
		{
			Hide();
			Show();
		}

		#region MagicalUnfocusMagic

		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);

			Console.WriteLine("Removing Focus");

			//Set the window style to noactivate.
			WindowInteropHelper helper = new WindowInteropHelper(this);
			SetWindowLong(helper.Handle, GWL_EXSTYLE,
				GetWindowLong(helper.Handle, GWL_EXSTYLE) | WS_EX_NOACTIVATE);
		}



		private const int GWL_EXSTYLE = -20;
		private const int WS_EX_NOACTIVATE = 0x08000000;


		[DllImport("user32.dll")]
		public static extern IntPtr SetWindowLong(IntPtr hWnd,
												  int nIndex,
												  int dwNewLong);

		[DllImport("user32.dll")]
		public static extern int GetWindowLong(IntPtr hWnd,
											   int nIndex);
		#endregion
	}
}
