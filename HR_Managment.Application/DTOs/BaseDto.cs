﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.DTOs
{
    public class BaseDto<TKey>
    {
        public required TKey Id { get; set; }
    }
}
