using ProjectRothSSA1.Models.Data;

namespace ProjectRothSSA1 {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var _context = new Ssa1bikeStoreContext();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainFrm(_context));
        }
    }
}