using MediatR;

namespace MediatROrnek.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var modeliGoster = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            //Bir repodan alınacağı zaman async olabilir
            //Use async when get product from repos
            return Task.FromResult(modeliGoster);
            //Product repositoryden gelicek
            //Get product from repos
        }
    }
}
