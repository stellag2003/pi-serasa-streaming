namespace pi_serasa_streaming
{
    internal static class Program
    {
        public static Usuario usuario;
        public static Reproducao reproducao;
        public static void filmeClicado(Reproducao reproducao)
        {
            Program.reproducao = reproducao;
            TelaReproducao reproducao1= new TelaReproducao();
            reproducao1.Show();
        }

        public static List<Reproducao> nomeFilme = new List<Reproducao>();
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaU());


           

        }
    }
}