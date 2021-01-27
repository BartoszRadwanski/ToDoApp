using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Mappers
{
    public class BaseMapper<T,U>
    {
        private IMapper _mapper;
        /// <summary>
        /// Generic class for mapper
        /// </summary>
        /// <param name="itemModel">Class model</param>
        /// <param name="itemEntity">Model for entityFramework</param>
        //TaskToDo=item Entity
        //toDOTaskModel=item model
        public BaseMapper(T itemEntity, U itemModel)
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<T, U>()
                .ReverseMap();
            }).CreateMapper();
        }
        /// <summary>
        /// This fucntion return entity object ready to save in database
        /// </summary>
        /// <param name="itemEntity"></param>
        /// <returns></returns>
        public U Map(T itemEntity)
        {
            return _mapper.Map<U>(itemEntity);
        }
        /// <summary>
        /// This fucntion return class object to work with it
        /// </summary>
        /// <param name="itemModel"></param>
        /// <returns></returns>
        public T Map(U itemModel)
        {
            return _mapper.Map<T>(itemModel);
        }
    }
}
