using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CqrsSample.Infrastructure
{
    public interface IHandle<in TCommand> where TCommand : ICommand
    {
        IAggregate Handle(TCommand command);
    }
}