using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Model
{
	public class Comment
	{
		[Required]
		public string ID { get; set; }

		[Required]
		public string BlogID { get; set; }

		[Required]
		public string Author { get; set; }

		[Required, EmailAddress]
		public string Email { get; set; }

		[Required]
		public string Content { get; set; }

		[Required]
		public DateTime CreatedOn { get; set; } 
	}
}
