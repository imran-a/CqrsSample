namespace CqrsSample.Contracts.Commands
namespace CqrsSample.Infrastructure
open System

// user commands
type CreateUser = {Id: Guid; FirstName: string; LastName: string } with interface ICommand