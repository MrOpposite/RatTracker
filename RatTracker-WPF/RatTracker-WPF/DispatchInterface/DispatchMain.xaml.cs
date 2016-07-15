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

namespace RatTracker_WPF.DispatchInterface
{
	/// <summary>
	/// Interaction logic for DispatchMain.xaml
	/// </summary>
	public partial class DispatchMain : Window
	{
		private APIWorker m_ApiWorker;
		private string m_PW = "lalala"; //doing this for now as absolver has no field for password in the settings dialog
		private string m_UN = "am@drl.dk"; //temp hack for username and pw
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
	}
}
