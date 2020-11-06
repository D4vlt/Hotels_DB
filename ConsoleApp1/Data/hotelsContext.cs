using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ConsoleApp1.Models;

namespace ConsoleApp1.Data
{
    public partial class hotelsContext : DbContext
    {
        public hotelsContext()
        {
        }

        public hotelsContext(DbContextOptions<hotelsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Должности> Должности { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<Номера> Номера { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Услуги> Услуги { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
              //  optionsBuilder.UseSqlite("Data Source=C:\\DB\\hotels.db");
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library_db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Должности>(entity =>
            {
                entity.HasKey(e => e.КодДолжноти);

                entity.Property(e => e.КодДолжноти)
                    .HasColumnName("Код_должноти")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Обязанности).HasColumnType("INT");

                entity.Property(e => e.Оклад).HasColumnType("INT");

                entity.Property(e => e.Требования).HasColumnType("INT");
            });

            modelBuilder.Entity<Клиенты>(entity =>
            {
                entity.HasKey(e => e.ПаспортныеДанные);

                entity.HasIndex(e => e.КодНомера)
                    .IsUnique();

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ДатаВыезда)
                    .HasColumnName("Дата_выезда")
                    .HasColumnType("INT");

                entity.Property(e => e.ДатаЗаселения)
                    .HasColumnName("Дата_заселения_")
                    .HasColumnType("INT");

                entity.Property(e => e.КодНомера)
                    .HasColumnName("Код_номера")
                    .HasColumnType("INT");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги1)
                    .HasColumnName("Код_услуги_1")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги2)
                    .HasColumnName("Код_услуги_2")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги3)
                    .HasColumnName("Код_услуги_3")
                    .HasColumnType("INT");

                entity.Property(e => e.Стоимость)
                    .HasColumnName("Стоимость_")
                    .HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодНомераNavigation)
                    .WithOne(p => p.Клиенты)
                    .HasForeignKey<Клиенты>(d => d.КодНомера)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодСотрудникаNavigation)
                    .WithMany(p => p.Клиенты)
                    .HasForeignKey(d => d.КодСотрудника)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслуги1Navigation)
                    .WithMany(p => p.КлиентыКодУслуги1Navigation)
                    .HasForeignKey(d => d.КодУслуги1)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслуги2Navigation)
                    .WithMany(p => p.КлиентыКодУслуги2Navigation)
                    .HasForeignKey(d => d.КодУслуги2)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслуги3Navigation)
                    .WithMany(p => p.КлиентыКодУслуги3Navigation)
                    .HasForeignKey(d => d.КодУслуги3)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Номера>(entity =>
            {
                entity.HasKey(e => e.КодНомера);

                entity.Property(e => e.КодНомера)
                    .HasColumnName("Код_номера")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Вместимость)
                    .HasColumnName("Вместимость_")
                    .HasColumnType("INT");

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Описание).HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("INT");
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.HasIndex(e => e.ПаспортныеДанные)
                    .IsUnique();

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодДолжноти)
                    .HasColumnName("Код_должноти")
                    .HasColumnType("INT");

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("INT");

                entity.Property(e => e.Пол).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодДолжнотиNavigation)
                    .WithMany(p => p.Сотрудники)
                    .HasForeignKey(d => d.КодДолжноти)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Услуги>(entity =>
            {
                entity.HasKey(e => e.КодУслуги);

                entity.Property(e => e.КодУслуги)
                    .HasColumnName("Код_услуги")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование)
                    .HasColumnName("Наименование_")
                    .HasColumnType("INT");

                entity.Property(e => e.Описание).HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
