namespace WindowsClases.Models
{
    class Perro
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Tamaño { get; set; }
        public string Caracter { get; set; }
        public int Peso { get; set; }

        public Perro() { }

        public Perro(string nombre, string raza, string tamaño, string caracter, int peso)
        {
            Nombre = nombre;
            Raza = raza;
            Tamaño = tamaño;
            Caracter = caracter;
            Peso = peso;
        }
    }
}
