namespace AutogermanaTest.Core.Interfaces.Repositories
{
    public interface IRepositoryWrapper
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
    }
}
