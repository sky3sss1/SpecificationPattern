namespace Infrastraction.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(e => e.Id).HasName("OrderItem_pkey");

        builder.ToTable(tb => tb.HasComment("Товары в заказе"));

        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasComment("Идентификатор");

        builder.Property(e => e.CreateDate).HasComment("Дата создания");

        builder.Property(e => e.UpdateDate).HasComment("Дата обновления");

        builder.Property(e => e.OrderId).HasComment("Id заказа");

        builder.HasOne(e => e.Order)
            .WithMany(e => e.OrderItems)
            .HasForeignKey(e => e.OrderId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_OrderItem_Order");
    }
}
