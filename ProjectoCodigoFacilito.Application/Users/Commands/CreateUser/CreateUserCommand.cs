﻿using MediatR;
using ProjectoCodigoFacilito.Application.Users.Queries.GetUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoCodigoFacilito.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<UserDTO>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
