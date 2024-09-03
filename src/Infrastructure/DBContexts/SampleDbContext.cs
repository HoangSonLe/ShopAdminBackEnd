using Core.Enums;
using Infrastructure.Entitites;
using Infrastructure.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DBContexts
{
    public class SampleReadOnlyDBContext : SampleDBContext
    {
        public SampleReadOnlyDBContext() : base()
        {
        }
        public SampleReadOnlyDBContext(DbContextOptions<SampleDBContext> options)
           : base(options)
        {

        }
        public override int SaveChanges()
        {
            throw new NotSupportedException();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }
    }
    public class SampleDBContext : DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> options)
           : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public SampleDBContext() : base()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> CustomerInfors { get; set; }
        public virtual DbSet<Employee> EmployeeInfors { get; set; }
        public virtual DbSet<FileAttachments> FileAttachments { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Post_Category> Post_Categories { get; set; }
        public virtual DbSet<Post_Tag> Post_Tags { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Tag> Product_Tags { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Promotion_Tag> Promotion_Tags { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UnitConversion> UnitConversions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Role> User_Roles { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new BillDetailEntityConfigurations());
            modelBuilder.ApplyConfiguration(new BillEntityConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfigurations());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfigurations());
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfigurations());
            modelBuilder.ApplyConfiguration(new FileAttachmentsEntityConfigurations());
            modelBuilder.ApplyConfiguration(new InventoryEntityConfigurations());
            modelBuilder.ApplyConfiguration(new InventoryTransactionEntityConfigurations());
            modelBuilder.ApplyConfiguration(new Post_CategoryEntityConfigurations());
            modelBuilder.ApplyConfiguration(new Post_TagEntityConfigurations());
            modelBuilder.ApplyConfiguration(new PostEntityConfigurations());
            modelBuilder.ApplyConfiguration(new Product_TagEntityConfigurations());
            modelBuilder.ApplyConfiguration(new ProductEntityConfigurations());
            modelBuilder.ApplyConfiguration(new ProductUnitEntityConfigurations());
            modelBuilder.ApplyConfiguration(new Promotion_TagEntityConfigurations());
            modelBuilder.ApplyConfiguration(new PromotionEntityConfigurations());
            modelBuilder.ApplyConfiguration(new RoleEntityConfigurations());
            modelBuilder.ApplyConfiguration(new ShipEntityConfigurations());
            modelBuilder.ApplyConfiguration(new TagEntityConfigurations());
            modelBuilder.ApplyConfiguration(new TransactionEntityConfigurations());
            modelBuilder.ApplyConfiguration(new UnitConversionEntityConfigurations());
            modelBuilder.ApplyConfiguration(new UnitEntityConfigurations());
            modelBuilder.ApplyConfiguration(new User_RoleEntityConfigurations());
            modelBuilder.ApplyConfiguration(new UserEntityConfigurations());
            modelBuilder.ApplyConfiguration(new VoucherEntityConfigurations());
            modelBuilder.ApplyConfiguration(new WarehouseEntityConfigurations());

            //Default value for column entity models

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = 1,
                    Name = "Admin",
                    Description = "Admin",
                    CreatedDate = DateTime.Now,
                    State = (int)EState.Active,
                    EnumActionList = new List<int> { 1, 2 },
                    NameNonUnicode = "Admin",
                },
                new Role()
                {
                    Id = 2,
                    Name = "Dev",
                    Description = "Dev",
                    CreatedDate = DateTime.Now,
                    State = (int)EState.Active,
                    EnumActionList = new List<int> { 1, 2 },
                    NameNonUnicode = "Dev"
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    UserName = "Admin",
                    PasswordHash = "/cA7ZZQqtyOGVwe1kEbPSg==", //123456
                    PhoneNumber = "",
                    CreatedDate = DateTime.Now,
                    State = (int)EState.Active,
                    Email = "",
                    AccountType = EAccountType.Employee,
                    RefreshToken = ""
                }
            );



            base.OnModelCreating(modelBuilder);
        }

    }
}
