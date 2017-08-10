using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using CSharpDemo.Models.Entity;
using CSharpDemo.Models.DTO;
using System.Collections;
using CSharpDemo.Models.ViewModel;

namespace CSharpDemo.Utility
{
    public static class MapperHelper
    {
        public static T MapTo<T>(this object obj)
        {
            if (obj == null)
            {
                return default(T);
            }
            return Mapper.Map<T>(obj);
        }

        public static List<TDestination> MapTo<TDestination>(this IEnumerable source)
        {
            if (source == null)
            {
                return null;
            }
            return Mapper.Map<List<TDestination>>(source);
        }

        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new EntityDtoTransitionProfile());
                cfg.AddProfile(new ViewModelDtoTransitionProfile());
                cfg.AddProfile(new OtherTransitionProfile());
            });
        }
    }

    /// <summary>
    /// Entity 与 Dto 的Mapper配置
    /// </summary>
    public class EntityDtoTransitionProfile : Profile
    { 
        public EntityDtoTransitionProfile()
        {
            CreateMap<Contact, ContactDTO>().ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Enrollment, EnrollmentDTO>().ReverseMap();
        }


    }

    /// <summary>
    /// ViewModel 与 Dto 的Mapper配置
    /// </summary>
    public class ViewModelDtoTransitionProfile : Profile
    {
        public ViewModelDtoTransitionProfile()
        {
            CreateMap<ContactViewModel, ContactDTO>().ReverseMap();
        }
    }

    public class OtherTransitionProfile : Profile
    {
        
    }
}
