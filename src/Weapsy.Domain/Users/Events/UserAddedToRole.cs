﻿using System;
using Weapsy.Cqrs.Domain;
using Weapsy.Framework.Domain;

namespace Weapsy.Domain.Users.Events
{
    public class UserAddedToRole : DomainEvent
    {
        public string RoleName { get; set; }
    }
}
