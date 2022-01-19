namespace MultiTenantApp.Contracts;

public class Paged<T>
{
    public IReadOnlyCollection<T> Payload { get; set; }

    public int PageNumber { get; set; }
}