using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



////
///     Nom: ISAAC Sammuel Ramclief
///     Cours: Introduction à l'intelligence artificielle
///     Devoir: Devoir 2
///             -> Jeu de Tic Tac Toe en utilisant les méthodes prédéfinies reçues.
///


namespace TiTaTo
{
    /// <summary>
    /// Classe principale du jeu
    /// </summary>
    public partial class frmTiTaTo : Form
    {

            /// <summary>
            /// Tableau représentant les positions des joueurs
            /// </summary>
            String[] positions = new String[9] {
                "", "", "" ,
                "", "", "" ,
                "", "", ""
            };
            int CompteurMove = 0;
            bool bPremierJoueur = true;

            public frmTiTaTo()
            {
                InitializeComponent();
            }
            /// <summary>
            /// Fonction permettant de calculer le gagnant
            /// </summary>
            /// <returns>X ou bien O</returns>
            private String calculateWinner()
            {
                // Winning combinations
                int[,] winningCombos = new int[,] {
                    { 0, 1, 2 },  // Row 1
                    { 3, 4, 5 },  // Row 2
                    { 6, 7, 8 },  // Row 3
                    { 0, 3, 6 },  // Column 1
                    { 1, 4, 7 },  // Column 2
                    { 2, 5, 8 },  // Column 3
                    { 0, 4, 8 },  // Diagonal top-left to bottom-right
                    { 2, 4, 6 }   // Diagonal top-right to bottom-left
                };

                for (int i = 0; i < 8; i++)
                {
                    int a = winningCombos[i, 0];
                    int b = winningCombos[i, 1];
                    int c = winningCombos[i, 2];

                    // Check if all three positions in a winning combo are the same and not empty
                    if (positions[a] != "" && positions[a] == positions[b] && positions[b] == positions[c])
                    {
                        return positions[a]; // Return "X" or "O"
                    }
                }

                return null; // No winner yet
            }
            /// <summary>
            /// Fonction permettant de gérer le clique sur un bouton
            /// </summary>
            /// <param name="btn"></param>
            /// <param name="index"></param>
            private void GererClique(Button btn, int index)
                {
                    if (CompteurMove > 8)
                        return; // Ne rien faire

                    if (bPremierJoueur)
                    {
                        bPremierJoueur = false;
                        positions[index] = "X";
                        btn.Text = "X";
                        btn.ForeColor = Color.Red;
                        if (calculateWinner() == "X")
                        {
                            lblMessage.Text = "Joueur 1 a gagné !!!!";
                            CompteurMove = 9;
                        }
                    }
                    else
                    {
                        bPremierJoueur = true;
                        positions[index] = "O";
                        btn.Text = "O";
                        btn.ForeColor = Color.Blue;
                        if (calculateWinner() == "O")
                        {
                            lblMessage.Text = "Joueur 2 a gagné !!!!";
                            CompteurMove = 9;
                        }
                    }
                    CompteurMove++;
                }

            private void btn0_Click(object sender, EventArgs e)
            {
                GererClique(btn0, 0);
            }

            private void btn1_Click(object sender, EventArgs e)
            {
                GererClique(btn1, 1);
            }

            private void btn2_Click(object sender, EventArgs e)
            {
                GererClique(btn2, 2);
            }

            private void btn3_Click(object sender, EventArgs e)
            {
                GererClique(btn3, 3);
            }

            private void btn4_Click(object sender, EventArgs e)
            {
                GererClique(btn4, 4);
            }

            private void btn5_Click(object sender, EventArgs e)
            {
                GererClique(btn5, 5);
            }

            private void btn6_Click(object sender, EventArgs e)
            {
                GererClique(btn6, 6);
            }

            private void btn7_Click(object sender, EventArgs e)
            {
                GererClique(btn7, 7);
            }

            private void btn8_Click(object sender, EventArgs e)
            {
                GererClique(btn8, 8);
            }

            private void btnCommencez_Click(object sender, EventArgs e)
            {
                // Rendre les boutons prêts
                btn0.Enabled = true; btn0.Text = "";
                btn1.Enabled = true; btn1.Text = "";
                btn2.Enabled = true; btn2.Text = "";
                btn3.Enabled = true; btn3.Text = "";
                btn4.Enabled = true; btn4.Text = "";
                btn5.Enabled = true; btn5.Text = "";
                btn6.Enabled = true; btn6.Text = "";
                btn7.Enabled = true; btn7.Text = "";
                btn8.Enabled = true; btn8.Text = "";
                // Ré-intinialiser compteur
                CompteurMove = 0;
                // Ré-intinialiser positions
                for (int i = 0; i <= 8; i++)
                {
                    positions[i] = "";
                }
                //
                lblMessage.Text = String.Empty;
            }

            /// <summary>
            /// Initialiser le jeu, rendre les boutons non cliquables
            /// jusqu'à ce que le joueur clique sur le bouton Commencez
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void frmTiTaTo_Load(object sender, EventArgs e)
            {
                btn0.Enabled = false; btn1.Enabled = false;
                btn2.Enabled = false; btn3.Enabled = false;
                btn4.Enabled = false; btn5.Enabled = false;
                btn6.Enabled = false; btn7.Enabled = false;
                btn8.Enabled = false;
            }

        private void frmTiTaTo_Load_1(object sender, EventArgs e)
        {

        }
    }

}
