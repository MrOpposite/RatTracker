using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatTracker_WPF.DispatchInterface.Models
{
	class RescueListItemModel : INotifyPropertyChanged
	{
		private string _Client;

		public string Client
		{
			get { return _Client; }
			set
			{
				if (value == _Client)
					return;

				_Client = value;
				OnPropertyChanged("Client");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
