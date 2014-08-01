using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CqrsSample.Infrastructure
{
    public interface IAggregate
    {
        IEnumerable<IEvent> UncommitedEvents();
        void ClearUncommitedEvents();
        int Version { get; }
        Guid Id { get; }
        void ApplyEvent(IEvent @event);
    }
}