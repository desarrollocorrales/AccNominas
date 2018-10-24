
namespace AccAsistencia
{
    public class Permiso
    {
        private string valor;
        private string nombre;
        
        public Permiso(string nombre, string valor)
        {
            this.nombre = nombre;
            this.valor = valor.ToLower();
        }

        public string Valor 
        {
            get { return this.valor; } 
        }
        public string Nombre
        {
            get { return this.nombre; } 
        }
    }
}
