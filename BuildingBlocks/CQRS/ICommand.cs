using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    public interface ICommand : ICommand<Unit>
    {

    }

    //defines a contract for all command types
    public interface ICommand <out TResponse> : IRequest<TResponse>
    {
    }
}
