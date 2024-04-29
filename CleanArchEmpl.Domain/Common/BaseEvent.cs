using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchEmpl.Domain.Common
{
    public abstract class BaseEvent : INotification
    {
        public DateTime DateOccured { get; protected set; } = DateTime.UtcNow;
    }
}
