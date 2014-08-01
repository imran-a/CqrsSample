using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CqrsSample.Infrastructure
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}