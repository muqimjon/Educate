using AutoMapper;
using Educate.Domain.Entities;
using Educate.Service.DTOs.Answers;
using Educate.Service.DTOs.Questions;
using Educate.Service.DTOs.Users;

namespace Educate.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Users
        CreateMap<User, UserResultDto>().ReverseMap();
        CreateMap<UserCreationDto, User>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();

        // Questions
        CreateMap<Question, QuestionResultDto>().ReverseMap();
        CreateMap<QuestionCreationDto, Question>().ReverseMap();
        CreateMap<QuestionUpdateDto, Question>().ReverseMap();

        // Answers
        CreateMap<Answer, AnswerResultDto>().ReverseMap();
        CreateMap<AnswerCreationDto, Answer>().ReverseMap();
        CreateMap<AnswerUpdateDto, Answer>().ReverseMap();
    }
}
