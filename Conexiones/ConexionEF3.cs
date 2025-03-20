using RetroBusters.Modelos;
using Microsoft.EntityFrameworkCore;
namespace RetroBusters.Conexiones;

public class ConexionEF3
    {
        private string string_conexion = "server=SANTY\\SQLEXPRESS;database=RetroBusters;Integrated Security=True;TrustServerCertificate=true;"; //RECORDAR PREGUNTARLE AL PROFESOR POR LA MODIFICACION DE LA INSTANCIA
        // server=localhost;database=db_instrumentos;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_instrumentos;Integrated Security=True;TrustServerCertificate=true;

        public void ConexionBasica()
        {
            var conexion = new Conexion3();
            conexion.StringConnection = this.string_conexion;

            var lista = conexion.Almacenes!.ToList();

            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento.Ubicacion_bodega.ToString() + ", " + 
                    elemento.Capacidad_bodega.ToString()+ ", "+
                    elemento.Id_bodega.ToString());
            }
        }

        /*public void ConexionInsert()
        {
            var conexion = new Conexion3();
            conexion.StringConnection = this.string_conexion;

            var tipo = conexion.Tipos!.FirstOrDefault(x => x.Nombre == "Viento");

            var instrumento = new Instrumentos();
            instrumento.Codigo = "TS-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            instrumento.Nombre = "Prueba";
            instrumento.Cantidad = 2;
            instrumento.Fecha = DateTime.Now;
            instrumento.Tipo = tipo!.Id;
            instrumento.Activo = false;

            conexion.Instrumentos!.Add(instrumento);
            conexion.SaveChanges();
        }
    }*/

    public class Conexion3 : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Almacenes>? Almacenes { get; set; }
        public DbSet<Miembros>? Miembros { get; set; }
        public DbSet<Empleados>? Empleados { get; set; }
        public DbSet<Envios>? Envios { get; set; }
        public DbSet<Reservas>? Reservas { get; set; }
        public DbSet<Peliculas>? Peliculas { get; set; }
        public DbSet<Snacks>? Snacks { get; set; }
        public DbSet<Reservas_Snacks>? Reservas_Snacks { get; set; }
    }
}