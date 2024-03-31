using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using add_users_to_list.Commands;
using add_users_to_list.Models;
using add_users_to_list.Views;

namespace add_users_to_list.ViewModel
{
	public class MainViewModel
	{
		public ObservableCollection<User> Users { get; set; }


		public ICommand ShowWindowCommand { get; set; }



		public MainViewModel()
		{
			Users = UserManager.GetUsers();

			ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);

		}

		private bool CanShowWindow(object obj)
		{
			return true;
		}

		private void ShowWindow(object obj)
		{
			var mainWindow = obj as Window;

			AddUser addUserWin = new AddUser();
			addUserWin.Owner = mainWindow;
			addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			addUserWin.Show();


		}
	}
}
