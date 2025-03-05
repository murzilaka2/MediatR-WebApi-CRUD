using MediatR;
using MediatRWebApi.Commands;
using MediatRWebApi.Interfaces;
using MediatRWebApi.Models;

namespace MediatRWebApi.Handlers
{
    public class GetUserByIdCommandHandler : IRequestHandler<GetUserByIdCommand, User>
    {
        private readonly IUser _userRepository;

        public GetUserByIdCommandHandler(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserByIdAsync(request.Id);
        }
    }

}
