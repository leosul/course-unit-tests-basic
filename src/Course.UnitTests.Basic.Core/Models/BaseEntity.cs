namespace Course.UnitTests.Basic.Core.Models;
public abstract class BaseEntity
{
    public Guid Id { get; set; }

    public BaseEntity() => Id = Guid.NewGuid();
}
