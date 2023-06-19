using MediatorDesignPattern.MediatorPattern.Results;
using MediatR;

namespace MediatorDesignPattern.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<GetUpdateProductByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
