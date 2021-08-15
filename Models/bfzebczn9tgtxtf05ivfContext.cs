using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GestorPC.Models
{
    public partial class bfzebczn9tgtxtf05ivfContext : DbContext
    {
        public bfzebczn9tgtxtf05ivfContext()
        {
        }

        public bfzebczn9tgtxtf05ivfContext(DbContextOptions<bfzebczn9tgtxtf05ivfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Computadoras> Computadoras { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=bfzebczn9tgtxtf05ivf-mysql.services.clever-cloud.com;uid=upwcz2qi6zunfx4u;pwd=AQyDzxsaue0iRRcNq68f;database=bfzebczn9tgtxtf05ivf", x => x.ServerVersion("8.0.15-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.DniCliente)
                    .HasName("PRIMARY");

                entity.Property(e => e.DniCliente)
                    .HasColumnName("DNI_Cliente")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApellidoCliente)
                    .HasColumnName("Apellido_Cliente")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CorreoCliente)
                    .HasColumnName("Correo_Cliente")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha_Nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.LugarNacimiento)
                    .HasColumnName("Lugar_Nacimiento")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("Nombre_Cliente")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelefonoCliente)
                    .HasColumnName("Telefono_Cliente")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Computadoras>(entity =>
            {
                entity.HasKey(e => e.IdComputadora)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdComputadora)
                    .HasColumnName("ID_Computadora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaLlegada)
                    .HasColumnName("Fecha_Llegada")
                    .HasColumnType("date");

                entity.Property(e => e.Marca)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modelo)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Precio).HasColumnType("decimal(10,0)");
            });

            modelBuilder.Entity<Facturas>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.DniCliente)
                    .HasName("FK_DNICliente");

                entity.HasIndex(e => e.IdComputadora)
                    .HasName("FK_IDComputadora");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("FK_IDUsuario");

                entity.Property(e => e.IdFactura)
                    .HasColumnName("ID_Factura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DniCliente)
                    .HasColumnName("DNI_Cliente")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.FechaVenta)
                    .HasColumnName("Fecha_Venta")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdComputadora)
                    .HasColumnName("ID_Computadora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalVenta).HasColumnName("Total_Venta");

                entity.HasOne(d => d.DniClienteNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.DniCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DNICliente");

                entity.HasOne(d => d.IdComputadoraNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdComputadora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDComputadora");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDUsuario");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApellidoUsuario)
                    .IsRequired()
                    .HasColumnName("Apellido_Usuario")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CorreoUsuario)
                    .IsRequired()
                    .HasColumnName("Correo_Usuario")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("Nombre_Usuario")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelefonoUsuario)
                    .IsRequired()
                    .HasColumnName("Telefono_Usuario")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TurnoUsuario)
                    .IsRequired()
                    .HasColumnName("Turno_Usuario")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
