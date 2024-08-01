using AutoMapper;
using NoteControlNet8.Models;
using NoteControlNet8.Models.Dto;

namespace NoteControlNet8.Mapper
{
    public class NoteControlMapper: Profile
    {
        public NoteControlMapper()
        {
            CreateMap<Subject, SubjectDto>().ReverseMap();
        }
    }
}
