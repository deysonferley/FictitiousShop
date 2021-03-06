namespace ProductService.Events.Contracts {
    using System;

    /// <summary>
    ///  Contract for ProductUpdated Event 
    /// </summary>
    public interface IProductUpdatedEvent : IIntegrationEvent {
        int ProductId { get; }
        string Name { get; }
        string Description { get; }
        decimal UnitPrice { get; }
        long UnitsInStock { get; }
        bool IsActive { get; }
    }
}