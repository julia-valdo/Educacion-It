namespace WindowsClases.Models
{
    class Celular
    {
        public int Almacenamiento { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Origen { get; set; }
        public double Precio { get; set; }        

        public Celular() { }

        public Celular(string marca, string modelo, string origen, int almacenamiento, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Origen = origen;
            Almacenamiento = almacenamiento;
            Precio = precio;
        }
    }
}
