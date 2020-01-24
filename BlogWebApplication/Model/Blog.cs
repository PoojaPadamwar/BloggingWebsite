using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Model
{
	public class Blog
	{
		[Required]
		public string ID { get; set; } 

		[Required]
		public string Title { get; set; }

		[Required]
		public string Content { get; set; }

		public DateTime CreatedOn { get; set; } 

		public DateTime ModifiedOn { get; set; } 

		public IList<Comment> Comments { get; } 
	}
}
