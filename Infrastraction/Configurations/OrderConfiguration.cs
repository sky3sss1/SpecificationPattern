namespace Infrastraction.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(e => e.Id).HasName("Order_pkey");

        builder.ToTable(tb => tb.HasComment("Заказы пользователя"));

        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasComment("Идентификатор");

        builder.Property(e => e.CreateDate).HasComment("Дата создания");

        builder.Property(e => e.UpdateDate).HasComment("Дата обновления");

        builder.Property(e => e.OrderNumber).HasComment("Номер заказа");

        builder.Property(e => e.UserId).HasComment("Id пользователя");

        builder.Property(e => e.StatusId).HasComment("Id статуса");

        builder.HasOne(e => e.User)
            .WithMany(e => e.Orders)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Order_User");

        builder.HasOne(e => e.Status)
            .WithMany(e => e.Orders)
            .HasForeignKey(e => e.StatusId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Order_Status");
    }
}
