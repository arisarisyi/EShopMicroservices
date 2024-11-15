using MediatR;

namespace Catalog.API.Models.Products.CreateProduct;

public record CreateProductCommand(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price
    ) :IRequest<CreateProductResult>;

public record CreateProductResult(Guid id);

internal class CreateProductCommandHandler :IRequestHandler<CreateProductCommand,CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Business logic
        throw new NotImplementedException();
    }
}