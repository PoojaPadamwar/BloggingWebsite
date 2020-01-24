using BlogWebApplication.DBEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication
{
	public class BlogContext: DbContext
	{
		private string connectionString;

		public BlogContext(string connectionString)
		{
			this.connectionString = connectionString;
		}
		public BlogContext(DbContextOptions<BlogContext> options)
						: base(options)
		{
		}

		public virtual DbSet<BlogDBEntity> Blog { get; set; }
		public virtual DbSet<CommentDBEntities> Comment { get; set; }
		public virtual DbSet<UserDBEntities> User { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Filename=./blog.db");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Comment>()
			//		.HasKey(c => new { c.ID });
			//modelBuilder.Entity<User>()
			//	.HasKey(u => new { u.UserID });
			//modelBuilder.Entity<Blog>()
			//	.HasKey(b => new { b.ID });
		}
	}
}
