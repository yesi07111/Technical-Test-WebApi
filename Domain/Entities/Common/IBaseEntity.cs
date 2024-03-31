namespace Domain.Entities.Common;

public interface IBaseEntity<T>
{
    public T Id { get; set; }
}