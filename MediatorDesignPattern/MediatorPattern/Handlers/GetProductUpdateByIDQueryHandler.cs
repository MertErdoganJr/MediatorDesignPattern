using MediatorDesignPattern.DAL;
using MediatorDesignPattern.MediatorPattern.Queries;
using MediatorDesignPattern.MediatorPattern.Results;
using MediatR;

namespace MediatorDesignPattern.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetUpdateProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetUpdateProductByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetUpdateProductByIDQueryResult
            {
                ProductCategory = values.ProductCategory,
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock
            };
        }
    }
}
