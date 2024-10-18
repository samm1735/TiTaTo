using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


////
///     Nom: ISAAC Sammuel Ramclief
///     Cours: Introduction à l'intelligence artificielle
///     Devoir: Devoir 2
///             -> Jeu de Tic Tac Toe en utilisant les méthodes prédéfinies reçues.
///             
///     ****    VOIR LE FICHIER frmTiTaTo.cs    ****
///


namespace TiTaTo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTiTaTo());
        }
    }
}
