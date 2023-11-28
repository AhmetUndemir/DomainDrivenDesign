﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SeedWork
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        private ICollection<INotification> _domainEvents;
        public ICollection<INotification> DomainEvents => _domainEvents;

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents.Add(eventItem);
        }
    }
}
