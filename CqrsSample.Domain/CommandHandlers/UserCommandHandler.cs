using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CqrsSample.Domain.Aggregates;
using CqrsSample.Infrastructure;
using CqrsSample.Infrastructure.Exceptions;

namespace CqrsSample.Domain.CommandHandlers
{
    internal class UserCommandHandler : IHandle<CreateUser>
    {
        private readonly IDomainRepository _domainRepository;

        public UserCommandHandler(IDomainRepository domainRepository)
        {
            _domainRepository = domainRepository;
        }

        public IAggregate Handle(CreateUser command)
        {
            try
            {
                var user = _domainRepository.GetById<User>(command.Id);
                throw new Exception(command.Id.ToString());
            }
            catch (AggregateNotFoundException)
            {
                // expected?
            }

            return User.Create(command.Id, command.FirstName, command.LastName);
        }
    }
}
