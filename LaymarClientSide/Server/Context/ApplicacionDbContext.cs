using LaymarClientSide.Shared.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace LaymarClientSide.Server.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //ListaPrecioFamiliaProducto
        }

        public virtual DbSet<PersonaJuridica> personaJuridica { get; set; }
        public virtual DbSet<Cliente> cliente { get; set; }
        public virtual DbSet<Proveedor> proveedor { get; set; }

        public virtual DbSet<Producto> producto { get; set; }
        public virtual DbSet<Comprobante> comprobante { get; set; }
        public virtual DbSet<TipoComprobante> tipoComprobante { get; set; }
        public virtual DbSet<EstadoComprobante> estadoComprobante { get; set; }
        public virtual DbSet<DetalleFactura> detalleFactura { get; set; }
        public virtual DbSet<Sucursal> sucursal { get; set; }

        public virtual DbSet<Caja> caja { get; set; }
        public virtual DbSet<MovimientoCaja> movimientoCaja { get; set; }
        public virtual DbSet<TipoMovimientoCaja> tipoMovimientoCaja { get; set; }

        public virtual DbSet<Stock> stock { get; set; }
        public virtual DbSet<MovimientoStock> movimientoStock { get; set; }
        public virtual DbSet<TipoMovimientoStock> tipoMovimientoStock { get; set; }
        public virtual DbSet<UserSucursal> userSucursal { get; set; }

        public virtual DbSet<UserEntradas> userEntradas { get; set; }

    }
}