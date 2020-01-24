using AutoMapper;
using BlogWebApplication.DBEntities;
using BlogWebApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Mapper
{
	public class MapperProfile:Profile
	{
		public MapperProfile()
		{				
			CreateMap<Blog, BlogDBEntity>();
			CreateMap<Blog, BlogDBEntity>().ForMember(m => m.Commentsdto, mm => mm.Ignore());
			CreateMap<BlogDBEntity, Blog>().ForMember(m => m.Comments, mm => mm.MapFrom(mmm => mmm.Commentsdto));

			CreateMap<Comment, CommentDBEntities>();

			CreateMap<User, UserDBEntities>();
			
		}
	}
}
