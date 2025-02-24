namespace Infrastraction.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id).HasName("User_pkey");

        builder.ToTable(tb => tb.HasComment("Статусы заказов"));

        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasComment("Идентификатор");

        builder.Property(e => e.CreateDate).HasComment("Дата создания");

        builder.Property(e => e.UpdateDate).HasComment("Дата обновления");

        builder.Property(e => e.Name).HasComment("Имя пользователя");

        builder.Property(e => e.Email).HasComment("Почта пользователя");
    }
}
