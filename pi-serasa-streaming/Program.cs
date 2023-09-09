namespace pi_serasa_streaming
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< Updated upstream
            Application.Run(new Principal());
           

=======
            Application.Run(new TelaCadastroU());
>>>>>>> Stashed changes
        }
    }
}