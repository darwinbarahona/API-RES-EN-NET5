using Microsoft.EntityFrameworkCore;
namespace web_api_db.Models{
    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base (options){}
        public DbSet<Clientes> Clientes {get;set;}
        public DbSet<Empleados> Empleados {get;set;}
        public DbSet<Puestos> Puestos {get;set;}

    }
    class Conectar{
        private const string cadenaConexion = "server=localhost;port=3306=database=db_empresa;userid=usr_empresa;pwd=Empresa1234";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn= new Conexion (constructor.Options);
            return cn;
        }
    }
}