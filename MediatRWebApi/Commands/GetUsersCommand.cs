using MediatR;
using MediatRWebApi.Models;

namespace MediatRWebApi.Commands
{
    public class GetUsersCommand : IRequest<List<User>>
    {
    }
}
