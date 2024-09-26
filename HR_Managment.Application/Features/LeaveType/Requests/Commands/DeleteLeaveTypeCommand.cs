﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveType.Requests.Commands
{
    public class DeleteLeaveTypeCommand:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
