using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.DTOs;
using AutoMapper;

namespace _2_BlogApplication.Mappers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            //AppUser ı AppUserDto ya cevirme işlemi;
            //İsimlerin birebir uyuşmadıgı durumlarda(örn fullname dtoda var ama modelde yok oldugunu varsayarsak) formember adlı metottan yardım alırız 
            CreateMap<AppUser, AppUserDTO>().ForMember(dest=>dest.FullName, opt=>opt.MapFrom(src=>src.FirstName+" "+src.LastName));
            CreateMap<Article, ArticleDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
        }
    }
}