using MediatR;
using MediatRWebApi.Models;

namespace MediatRWebApi.Commands
{
    public class AddUserCommand : IRequest<User>
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public AddUserCommand(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
