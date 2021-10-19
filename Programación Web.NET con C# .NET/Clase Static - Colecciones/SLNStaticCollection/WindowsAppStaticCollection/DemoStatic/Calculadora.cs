namespace WindowsAppStaticCollection.DemoStatic
{
    /// <summary>
    /// La clase calculadora permite realizar calculos simples con dos números.
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// Calcular la suma de dos números.
        /// </summary>
        /// <param name="numero1"> Se espera un número entero. </param>
        /// <param name="numero2"> Se espera un número entero. </param>
        /// <returns> Devuelve el resultado de la suma de dos números. </returns>
        public static int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public static int Division(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
        public static int Multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
    }
}