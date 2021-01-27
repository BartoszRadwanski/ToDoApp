using AutoMapper;
using ToDoApp.Database.Entities;
using ToDoAppBL.Models;

namespace ToDoApp.Mappers
{
    public class DayMapper
    {
        private IMapper _Mapper;
        public DayMapper()
        {
            _Mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Day, DayModel>()
                .ReverseMap();
            }).CreateMapper();
        }
        public DayModel Map(Day day)
        {
            return _Mapper.Map<DayModel>(day);
        }

        public Day Map(DayModel dayModel)
        {
            return _Mapper.Map<Day>(dayModel);
        }
    }
}
