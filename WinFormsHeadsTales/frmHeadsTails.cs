using HeadsTailsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHeadsTales
{
    public partial class frmHeadsTails : Form
    {
        int flipincrement = 10;

        System.Windows.Forms.Timer timerflipcoin = new System.Windows.Forms.Timer();

        GameHeadsTails game = new GameHeadsTails();
        public frmHeadsTails()
        {
            InitializeComponent();

            lblWinner2.DataBindings.Add("Text", game, "Message");
            lblHeads.DataBindings.Add("Text", game, "HeadsDesc");
            lblTails.DataBindings.Add("Text", game, "TailsDesc");
            button6.Click += Btnflipcoin_Click;
            timerflipcoin.Enabled = false;
            timerflipcoin.Tick += Timerflipcoin_Tick;
            DisplayGame();
        }
        private void DisplayGame()
        {
            if (game.SideLanded == GameHeadsTails.CoinSideEnum.Heads)
            {
                picCoins.BackgroundImage = imageList1.Images[0];
            }
            if (game.SideLanded == GameHeadsTails.CoinSideEnum.Tails)
            {
                picCoins.BackgroundImage = imageList1.Images[1];
            }
        }
        private void RotateImage()
        {
            game.SetSideLanded();
            DisplayGame();
            game.NumTimesRotated++;

            if (game.NumTimesRotated == flipincrement)
            {
                timerflipcoin.Enabled = false;
                game.NumTimesRotated = 0;
                game.CheckLanded();
            }
        }
        private void Timerflipcoin_Tick(object? sender, EventArgs e)
        {
            RotateImage();
        }
        private void Btnflipcoin_Click(object? sender, EventArgs e)
        {
           if(game.GameActive == false)
            {
                game.NewGame();
            }
                timerflipcoin.Enabled = true; 
           
            
        }
    }
}

//































//private void SetCoin(int index)
//{
//    if (index == 0)
//    {
//        game.SideLanded = GameHeadsTails.CoinSideEnum.Heads;
//    }
//    else
//    {
//        game.SideLanded = GameHeadsTails.CoinSideEnum.Tails;
//    }
//}