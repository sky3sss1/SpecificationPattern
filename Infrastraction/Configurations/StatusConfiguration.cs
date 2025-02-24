using Status = Domain.Entities.Status;
namespace Infrastraction.Configurations;

public class StatusConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.HasKey(e => e.Id).HasName("Status_pkey");

        builder.ToTable(tb => tb.HasComment("Статусы заказов"));

        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasComment("Идентификатор");

        builder.Property(e => e.CreateDate).HasComment("Дата создания");

        builder.Property(e => e.UpdateDate).HasComment("Дата обновления");

        builder.Property(e => e.Name).HasComment("Название статуса");

        builder.Property(e => e.IsDeleted).HasComment("Удален ли статус");

        builder.HasData([
            new Status(){Id=Guid.Parse("11111111-1111-1111-1111-111111111111"), CreateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime(), Name="New", IsDeleted = false, UpdateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime()},
            new Status(){Id=Guid.Parse("22222222-2222-2222-2222-222222222222"), CreateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime(), Name="Delivering", IsDeleted = false, UpdateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime()},
            new Status(){Id=Guid.Parse("33333333-3333-3333-3333-333333333333"), CreateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime(), Name="Canceled", IsDeleted = false, UpdateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime()},
            new Status(){Id=Guid.Parse("44444444-4444-4444-4444-444444444444"), CreateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime(), Name="Delivered", IsDeleted = false, UpdateDate=DateTime.ParseExact("26/08/2024", "dd/MM/yyyy", null).ToUniversalTime()}
            ]);
    }
}
