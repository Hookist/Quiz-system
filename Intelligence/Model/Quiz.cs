namespace Intelligence.Model {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Quiz : DbContext {
        public Quiz()
            : base("name=Quiz") {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Answer>()
                .Property(e => e.AnswerText)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.QuestionText)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Answers)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.Questionid_Questions);

            modelBuilder.Entity<Test>()
                .Property(e => e.TestName)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Journals)
                .WithOptional(e => e.Test)
                .HasForeignKey(e => e.Testsid_Tests);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.GroupId)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Journals)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Userid_Users);
        }
    }
}
