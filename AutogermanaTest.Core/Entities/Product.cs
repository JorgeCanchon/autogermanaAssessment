namespace AutogermanaTest.Core.Entities
{
    public class Product
	{
		public int ID { get; init; }
		public int CodigoCategoria { get; init; }
		public string Codigo { get; init; }
		public string Nombre { get; init; }
		public decimal PrecioVenta { get; init; }
		public int Stock { get; init; }
		public string Descripcion { get; init; }
		public byte[] Imagen { get; init; }
		public bool Estado { get; private set; }
		public Category Category { get; set; }

        public Product()
        {

        }

		public Product(int id, int codigoCategoria, string nombre, decimal precioVenta, 
			int stock, string descripcion, byte[] imagen, bool estado)
        {
			ID = id;
			CodigoCategoria = codigoCategoria;
			Nombre = nombre;
			PrecioVenta = precioVenta;
			Stock = stock;
			Descripcion = descripcion;
			Imagen = imagen;
			Estado = estado;
        }

		public void SetEstado(bool estado)
        {
			Estado = estado;
        }
	}
}
