namespace WindowsAppStaticCollection.DemoStatic
{
    public class Cliente
    {
        public string Nombre { get; set; }
        #region Miembro estático
        private static int nroInstancias;
        public static int NroInstancias
        {
            get { return nroInstancias; }
        }
        #endregion
        public Cliente(string nombre)
        {
            Nombre = nombre;
            nroInstancias++;
        }
    }
}
