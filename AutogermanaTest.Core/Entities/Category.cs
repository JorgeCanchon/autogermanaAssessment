namespace AutogermanaTest.Core.Entities
{
    public class Category
    {
        public int ID { get; init; }
	    public string Nombre { get; init; }
        public string Descripcion { get; init; }
        public bool Estado { get; init; }
        public Product Product { get; set; }

        public Category()
        {

        }

        public Category(int id, string nombre, string descripcion, bool estado)
        {
            ID = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
