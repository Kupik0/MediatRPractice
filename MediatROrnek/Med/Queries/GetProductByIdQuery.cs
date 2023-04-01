using MediatR;

namespace MediatROrnek.Med.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
