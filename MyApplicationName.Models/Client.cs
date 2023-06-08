using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationName.Models
{
	public class Client
	{
		public int client_id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string phone { get; set; }
		public string address { get; set; }
		public string email { get; set; }
		public DateTime birthday { get; set; }
		public DateTime registration_date { get; set; }
		public int role_id { get; set; }
		public int coach_id { get; set; }
		public string gender { get; set; }
	}
}
