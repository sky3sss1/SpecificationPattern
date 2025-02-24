namespace Domain.Enums;

public static class Statuses
{
    /// <summary>
    /// Новый заказ
    /// </summary>
    public static readonly Guid New = Guid.Parse("11111111-1111-1111-1111-111111111111");
    /// <summary>
    /// Заказ в пути 
    /// </summary>
    public static readonly Guid Delivering = Guid.Parse("22222222-2222-2222-2222-222222222222");
    /// <summary>
    /// Заказ отменен
    /// </summary>
    public static readonly Guid Canceled = Guid.Parse("33333333-3333-3333-3333-333333333333");
    /// <summary>
    /// Заказ доставлен
    /// </summary>
    public static readonly Guid Delivered = Guid.Parse("44444444-4444-4444-4444-444444444444");
}

