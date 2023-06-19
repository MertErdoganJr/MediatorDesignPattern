using MediatorDesignPattern.DAL;
using MediatorDesignPattern.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace MediatorDesignPattern.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductCategory = request.ProductCategory,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
            });
            await _context.SaveChangesAsync();
        }
    }
}
