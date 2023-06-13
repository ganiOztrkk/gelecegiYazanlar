using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Entities;

namespace CampingApp.Services.extensions
{
    public static class MappingExtensions
    {
        /// <summary>
        /// This method converts your entities into DisplayResponseDto.
        /// </summary>
        /// <typeparam name="T">T suppose to be your DisplayResponseDto class</typeparam>
        /// <param name="entity">entity is your Enumaramble entity</param>
        /// <param name="mapper">your mapper object</param>
        /// <returns></returns>
        public static IEnumerable<T> ConvertToDisplayResponseDto<T>(this IEnumerable<IEntity> entity, IMapper mapper)
            where T : class
        {
            return mapper.Map<IEnumerable<T>>(entity);
        }
    }
}
