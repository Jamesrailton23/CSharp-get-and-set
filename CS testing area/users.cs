using System;
using System.Collections.Generic;
using System.Text;

namespace CS_testing_area
{
	internal class users
	{
		private string user_name;
		private int user_id;
		private bool user_is_cleared;
	

		public users(string name, int id, bool is_true)
		{
			Username = name;
			UserID = id;
			User_clearance = is_true;
		}

		public string Username
		{
			get
			{
				return user_name;
			}
			set
			{
				if (value != "gary")
				{
					user_name = value;
				}
				else
				{
					user_name = "no";
				}
			}
		}
		public int UserID
		{
			get
			{
				return user_id;
			}
			set
			{
				if (value < 1000)
				{
					user_id = value;
				}
				else
				{
					user_id = 0;
				}
			}
		}
		
		// every thing above here works, all below doesnt work 
		
		
		/*
		public bool User_clearance
		{
			get
			{
				return user_is_cleared;
			}
			set
			{
				if (Username == "gary")
				{
					user_is_cleared = true;
				}
				else
				{
					user_is_cleared = false;
				}
			}
		}
		*/
	}
}