namespace CqrsSample.Contracts.Events
open CqrsSample.Infrastructure
open System


// Product events
type UserCreated = {Id: Guid; FirstName: string; LastName: string }
    with interface IEvent with member this.Id with get() = this.Id
