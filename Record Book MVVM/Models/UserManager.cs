using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_users_to_list.Models
{
	public class UserManager
	{
		public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() 
		{	
			new User() 
			{ Email = "twin@peaks_mail.com", Name = "Laura Palmer" },
			new User 
			{ Email = "inland@mail.com", Name = "David Lynch" }, 
			new User 
			{ Email = "dune@mail.com", Name = "Dale Cooper" },
			new User 
			{ Email = "sher@mail.edu", Name = "Harry Truman" }, 
			new User
			{ Email = "novel@mail.org", Name = "Mark Frost" } };

		public static ObservableCollection<User> GetUsers()
		{
			return _DatabaseUsers;

		}


		public static void AddUser(User user)
		{
			_DatabaseUsers.Add(user);

		}

	}
}
