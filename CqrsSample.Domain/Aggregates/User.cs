using System;
using CqrsSample.Contracts.Events;
using CqrsSample.Infrastructure;

namespace CqrsSample.Domain.Aggregates
{
    internal class User : AggregateBase
    {
        public User()
        {
            RegisterTransition<UserCreated>(Apply);
        }

        internal string FirstName { get; private set; }
        internal string LastName { get; private set; }

        private void Apply(UserCreated obj)
        {
            Id = obj.Id;
            FirstName = obj.FirstName;
            LastName = obj.LastName;
        }

        private User(Guid id, string firstName, string lastName) : this()
        {
            RaiseEvent(new UserCreated(id, firstName, lastName));
        }

        public static IAggregate Create(Guid id, string firstName, string lastName)
        {
            return new User(id, firstName, lastName);
        }
    }
}