namespace TOBI.Model.Models
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public partial class TOBIDbConText : IdentityDbContext<ApplicationUser>
    {
        public TOBIDbConText()
            : base("name=TOBIDbConText")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<CommentForPlayer> CommentForPlayers { get; set; }
        public virtual DbSet<DetailMatch> DetailMatches { get; set; }
        public virtual DbSet<Error> Errors { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Match> Matches { get; set; }

        public DbSet<ApplicationGroup> ApplicationGroups { set; get; }
        public DbSet<ApplicationRole> ApplicationRoles { set; get; }
        public DbSet<ApplicationRoleGroup> ApplicationRoleGroups { set; get; }
        public DbSet<ApplicationUserGroup> ApplicationUserGroups { set; get; }

        public static TOBIDbConText Create()
        {
            return new TOBIDbConText();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>()
                .HasKey(i => new { i.UserId, i.RoleId })
                .ToTable("ApplicationUserRoles");

            modelBuilder.Entity<IdentityUserLogin>()
                .HasKey(i => i.UserId)
                .ToTable("ApplicationUserLogins");

            modelBuilder.Entity<IdentityRole>()
                .ToTable("ApplicationRoles");

            modelBuilder.Entity<IdentityUserClaim>()
                .HasKey(i => i.UserId)
                .ToTable("ApplicationUserClaims");

            modelBuilder.Entity<CommentForPlayer>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<CommentForPlayer>()
                .Property(e => e.User_id)
                .IsFixedLength();

            modelBuilder.Entity<CommentForPlayer>()
                .Property(e => e.UserComment_id)
                .IsFixedLength();

            modelBuilder.Entity<CommentForPlayer>()
                .Property(e => e.Contents)
                .IsFixedLength();

            modelBuilder.Entity<CommentForPlayer>()
                .Property(e => e.Comment_Date)
                .IsFixedLength();

            modelBuilder.Entity<CommentForPlayer>()
                .Property(e => e.StarVote)
                .IsFixedLength();

            modelBuilder.Entity<History>()
                .Property(e => e.History_id)
                .IsFixedLength();

            modelBuilder.Entity<History>()
                .Property(e => e.User_id)
                .IsFixedLength();

            modelBuilder.Entity<History>()
                .Property(e => e.DateHistory)
                .IsFixedLength();

            modelBuilder.Entity<History>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<History>()
                .Property(e => e.Contents)
                .IsFixedLength();
        }
    }
}
