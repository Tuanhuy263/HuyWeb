using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud
{
    public class Mapping
    {
        public static IMapper AutoMapping
        {
            get
            {
                return AutoMapperConfig.Mapper;
            }
        }
    }
}