using MediatR;

namespace MediatROrnek.Entities
{
    public class ProductEntity 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quentity { get; set; }
        public decimal Amount { get; set; }

    }
}
