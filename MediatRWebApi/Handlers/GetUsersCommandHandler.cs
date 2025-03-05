using MediatR;
using MediatRWebApi.Interfaces;
using MediatRWebApi.Models;
using MediatRWebApi.Commands;
using MediatRWebApi.Repositories;

namespace MediatRWebApi.Handlers
{
    public class GetUsersCommandHandler : IRequestHandler<GetUsersCommand, List<User>>
    {
        private readonly IUser _users;

        public GetUsersCommandHandler(IUser users)
        {
            _users = users;
        }

        public async Task<List<User>> Handle(GetUsersCommand request, CancellationToken cancellationToken)
        {
            return await _users.GetAllUsersAsync();
        }
    }
}
