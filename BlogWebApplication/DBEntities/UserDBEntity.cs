using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.DBEntities
{
	public class UserDBEntities
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string UserID { get; set; }
		public string UserName { get; set; }	
		public string Password { get; set; }		
		public bool RememberMe { get; set; }
	}
}
