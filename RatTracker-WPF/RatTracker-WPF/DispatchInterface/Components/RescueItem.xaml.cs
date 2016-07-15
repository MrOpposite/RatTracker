﻿using RatTracker_WPF.DispatchInterface.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RatTracker_WPF.DispatchInterface.Components
{
	/// <summary>
	/// Interaction logic for UserControl1.xaml
	/// </summary>
	public partial class RescueItem : UserControl
	{

		public string Client
		{
			get; set;
		}

		public RescueItem()
		{

			InitializeComponent();
			DataContext = this;
		}
	}
}
