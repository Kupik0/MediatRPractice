using MediatR;

namespace MediatROrnek.Med.Commands
{
    public class CreateProductCommand : IRequest<Guid>

    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
       return Task.FromResult(Guid.NewGuid());
                //repository aracılığı ile veri veritabanına gönderilir
                //send data to database by using repositories
            }
        }
    }
}
