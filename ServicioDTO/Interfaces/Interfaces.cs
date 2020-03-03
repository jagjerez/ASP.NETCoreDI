using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioDTO.Interfaces
{
    public interface IUser
    {
        Guid UserId { get; }
    }

    public interface IOperationTransient : IUser
    {
    }
    public interface IOperationScoped : IUser
    {
    }
    public interface IOperationSingleton : IUser
    {
    }
    public interface IOperationSingletonInstance : IUser
    {
    }
}
