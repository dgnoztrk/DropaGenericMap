namespace Mapper.Abstract
{
    public interface IGenericMapExtensions<T>
    {
        T Map(object objfrom, T objto);
        ValueTask<T> MapAsync(object objfrom, T objto);
    }
}
