﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class UserReadDto: BaseDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
    }
}
