using add_users_to_list.Commands;
using add_users_to_list.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace add_users_to_list.ViewModel
{
	public class AddUserViewModel
	{

		public ICommand AddUserCommand { get; set; }

		public string? Name { get; set; }
		public string? Email { get; set; }

		public AddUserViewModel()
		{
			AddUserCommand = new RelayCommand(AddUser, CanAddUser);


		}

		private bool CanAddUser(object obj)
		{
			return true;
		}

		private void AddUser(object obj)
		{

			UserManager.AddUser(new User() { Name = Name, Email = Email });

		}
	}
}
