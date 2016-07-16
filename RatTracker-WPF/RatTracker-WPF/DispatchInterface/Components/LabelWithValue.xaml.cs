﻿using System;
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
	/// Interaction logic for LabelWithValue.xaml
	/// </summary>
	public partial class LabelWithValue : UserControl
	{

		#region Text DP

		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}

		public static readonly DependencyProperty TextProperty =
			DependencyProperty.Register("Text", typeof(string),
				typeof(LabelWithValue), new PropertyMetadata(""));

		#endregion

		#region Label DP

		public string Label
		{
			get { return (string)GetValue(LabelProperty); }
			set { SetValue(LabelProperty, value); }
		}

		public static readonly DependencyProperty LabelProperty =
			DependencyProperty.Register("Label", typeof(string),
				typeof(LabelWithValue), new PropertyMetadata(""));

		#endregion


		public LabelWithValue()
		{
			InitializeComponent();
		}
	}
}
