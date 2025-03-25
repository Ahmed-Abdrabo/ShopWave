namespace Shopping.Web.Models.Ordering;

public class PaginatedResult<TEntity>
    (int pageIndex, int pageSize, long count, IEnumerable<TEntity> data) where TEntity : class
{
    public int PageSize { get; } = pageSize;
    public int PageIndex { get; } = pageIndex;
    public long Count { get; } = count;
    public IEnumerable<TEntity> Data { get; } = data; 
}
