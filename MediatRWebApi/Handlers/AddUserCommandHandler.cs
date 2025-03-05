using MediatR;
using MediatRWebApi.Commands;
using MediatRWebApi.Interfaces;
using MediatRWebApi.Models;

namespace MediatRWebApi.Handlers
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, User>
    {
        private readonly IUser _userRepository;

        public AddUserCommandHandler(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Name = request.Name,
                Email = request.Email
            };

            await _userRepository.CreateUserAsync(user);
            return user;
        }
    }
}
