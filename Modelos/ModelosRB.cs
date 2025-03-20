using System.ComponentModel.DataAnnotations.Schema;
namespace RetroBusters.Modelos;

public class Almacenes
{
    public int Id_bodega { get; set; }
    public string? Ubicacion_bodega { get; set; }
    public decimal Capacidad_bodega { get; set; }
}

public class Miembros
{
    public int Id_miembros { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha_registro { get; set; }
    public string? Nivel { get; set; }
    public int Puntos { get; set; }
}

public class Empleados
{
    public int Id_empleados { get; set; }
    public string? Nombre_empleado { get; set; }
    public string? Cargo_empleado { get; set; }
    public decimal Sueldo { get; set; } // Cambiado a decimal
    public DateTime Fecha_contratacion { get; set; }
}

public class Envios
{
    public int Id_envios { get; set; }
    public string? Estado { get; set; }
    public string? Direccion { get; set; }
    public string? Transportadora { get; set; }

    [ForeignKey("Empleado")]
    public int EmpleadoId { get; set; }
    public Empleados? _empleado { get; set; }
}

public class Reservas
{
    public int Id_Reserva { get; set; }
    public DateTime Fecha_Reserva { get; set; }
    public string? Estado { get; set; }
    
    [ForeignKey("Miembros")]
    public int MiembroId { get; set; }
    public Miembros? _Miembro { get; set; }
    
    [ForeignKey("Peliculas")]
    public int PeliculaId { get; set; }
    public Peliculas? _Pelicula { get; set; }
    
    [ForeignKey("Consolas")]
    public int ConsolaId { get; set; }
    public Consolas? _Consola { get; set; }
    
    [ForeignKey("Empleados")]
    public int EmpleadoId { get; set; }
    public Empleados? _Empleado { get; set; }
}

public class Peliculas
{
    public int Id_pelicula { get; set; }
    public string? Nombre_pelicula { get; set; }
    public string? Genero_Pelicula { get; set; }
    public DateTime Fecha_Estreno { get; set; }
    public bool Estado_pelicula { get; set; }
}

public class Consolas
{
    public int Id_consola { get; set; }
    public string? Tipo_consola { get; set; }
    public string? Marca_consola { get; set; }
    public int Estado_consola { get; set; }
    
    [ForeignKey("Almacen")]
    public int almacen { get; set; }
    public Almacenes? _almacen { get; set; }
}

public class Snacks
{
    public int Id_Snack { get; set; }
    public string? Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
}

public class Reservas_Snacks
{
    public int Id_Reservas_Snacks { get; set; }
    
    [ForeignKey("Snacks")]
    public int SnackId { get; set; }
    public Snacks? _Snack { get; set; }
    
    [ForeignKey("Reservas")]
    public int Reserva { get; set; }
    public Reservas? _Reserva { get; set; }
}