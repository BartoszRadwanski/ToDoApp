using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Database.Entities;
using ToDoAppBL.Models;

namespace ToDoApp.Mappers
{
    public class ToDoTaskMapper
    {
        private IMapper _Mapper;
        public ToDoTaskMapper()
        {
            _Mapper = new MapperConfiguration(config => 
            {
                config.CreateMap<TaskToDo, ToDoTaskModel>()
                .ReverseMap();
            }).CreateMapper();
        }
        public ToDoTaskModel Map(TaskToDo taskToDo)
        {
           return _Mapper.Map<ToDoTaskModel>(taskToDo);
        }

        public TaskToDo Map(ToDoTaskModel toDoTaskModel)
        {
            return _Mapper.Map<TaskToDo>(toDoTaskModel);
        }
    }
}
