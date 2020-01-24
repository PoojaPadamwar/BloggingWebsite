using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.DBEntities
{
	public class CommentDBEntities
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string ID { get; set; }
		public string BlogID { get; set; }
		public string Author { get; set; }	
		public string Email { get; set; }		
		public string Content { get; set; }	
		public DateTime CreatedOn { get; set; }
	}
}
