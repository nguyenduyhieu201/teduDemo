using Microsoft.EntityFrameworkCore;
using quanLyBanHang.Model.Models;
namespace quanLyBanHang.Data
{
    public class quanLyBanHangDbContext : DbContext
    {
        public quanLyBanHangDbContext()
        {
        }

        public quanLyBanHangDbContext (DbContextOptions<quanLyBanHangDbContext> options) : base(options)
        {

        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }



        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public object ApplicationGroups { get; internal set; }
        public object Users { get; internal set; }

        //public DbSet<Error> Errors { set; get; }
        //public DbSet<ContactDetail> ContactDetails { set; get; }
        //public DbSet<Feedback> Feedbacks { set; get; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>().HasNoKey();
            builder.Entity<ProductTag>().HasNoKey();
        }
    }
}
