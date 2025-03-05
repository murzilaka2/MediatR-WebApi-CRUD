using MediatR;
using MediatRWebApi.Models;

namespace MediatRWebApi.Commands
{
    public class GetUserByIdCommand : IRequest<User>
    {
        public int Id { get; set; }
        public GetUserByIdCommand(int id)
        {
            Id = id;
        }
    }

}
