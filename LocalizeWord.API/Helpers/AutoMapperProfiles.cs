using System.Linq;
using AutoMapper;
using LocalizeWord.API.Data;
using LocalizeWord.API.Dto;
using LocalizeWord.API.Models;

namespace LocalizeWord.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDetailsDto>();
            CreateMap<Word, WordListDto>()
            .ForMember(dest => dest.LanguageId, opt =>
            {
                opt.MapFrom(src => src.Language.Id);
            })
            .ForMember(dest => dest.LanguageKey, opt =>
            {
                opt.MapFrom(src => src.Language.ItemKey);
            })
            .ForMember(dest => dest.LanguageCaption, opt =>
            {
                opt.ResolveUsing(src => src.Language.ListItemCaptions != null ? src.Language.ListItemCaptions
                   .Where(s => s.ListItemId == src.Language.Id && s.Language == "fa")
                   .Select(c => c.Caption)
                   .FirstOrDefault() : null);
            })
            .ForMember(dest => dest.CategoryId, opt =>
            {
                opt.MapFrom(src => src.Category.Id);
            })
            .ForMember(dest => dest.CategoryKey, opt =>
            {
                opt.MapFrom(src => src.Category.ItemKey);
            })
            .ForMember(dest => dest.CategoryCaption, opt =>
            {
                opt.ResolveUsing(src => src.Category.ListItemCaptions != null ? src.Category.ListItemCaptions
                   .Where(s => s.ListItemId == src.Category.Id && s.Language == "fa")
                   .Select(c => c.Caption)
                   .FirstOrDefault() : null);
            });

            CreateMap<Word, WordDto>()
            .ForMember(dest => dest.LanguageId, opt =>
            {
                opt.MapFrom(src => src.Language.Id);
            })
            .ForMember(dest => dest.LanguageKey, opt =>
            {
                opt.MapFrom(src => src.Language.ItemKey);
            })
            .ForMember(dest => dest.LanguageCaption, opt =>
            {
                opt.ResolveUsing(src => src.Language.ListItemCaptions != null ? src.Language.ListItemCaptions
                   .Where(s => s.ListItemId == src.Language.Id && s.Language == "fa")
                   .Select(c => c.Caption)
                   .FirstOrDefault() : null);
            })
            .ForMember(dest => dest.CategoryId, opt =>
            {
                opt.MapFrom(src => src.Category.Id);
            })
            .ForMember(dest => dest.CategoryKey, opt =>
            {
                opt.MapFrom(src => src.Category.ItemKey);
            })
            .ForMember(dest => dest.CategoryCaption, opt =>
            {
                opt.ResolveUsing(src => src.Category.ListItemCaptions != null ? src.Category.ListItemCaptions
                   .Where(s => s.ListItemId == src.Category.Id && s.Language == "fa")
                   .Select(c => c.Caption)
                   .FirstOrDefault() : null);
            });


        }
    }
}