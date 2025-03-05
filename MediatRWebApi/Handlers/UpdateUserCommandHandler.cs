﻿using MediatR;
using MediatRWebApi.Commands;
using MediatRWebApi.Interfaces;
using MediatRWebApi.Models;

namespace MediatRWebApi.Handlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
    {
        private readonly IUser _userRepository;

        public UpdateUserCommandHandler(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(request.Id);
            if (user == null) return null;

            user.Name = request.Name;
            user.Email = request.Email;

            await _userRepository.UpdateUserAsync(user);

            return user;
        }
    }
}
