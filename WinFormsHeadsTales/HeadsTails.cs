
namespace WinFormsHeadsTales
{
    public partial class HeadsandTails : Form
    {
        Random rnd = new Random();
        int coinfliphead = 0;
        int coinfliptails = 0;
        string coinland = "";
        int numtimesrotated = 0;
        Dictionary<int, string> lstcoinside;
        List<Label> lstPoints;
        int flipincrement = 10;
        System.Windows.Forms.Timer timerflipcoin = new System.Windows.Forms.Timer();
        public HeadsandTails()
        {
            InitializeComponent();
            btnflipcoin.Click += Btnflipcoin_Click;
            picCoin.BackgroundImage = imageList1.Images[0];
            timerflipcoin.Interval = 50;
            timerflipcoin.Tick += Timerflipcoin_Tick;
            lstcoinside = new Dictionary<int, string>() { { 0, "Heads" }, { 1, "Tails" } };
            lstPoints = new List<Label>() { lblHeadsPoints, lblTailsPoints};
            NewGame();
        }
        private void NewGame()
        {
            foreach (Label lbl in lstPoints)
            {
                lbl.Text = "";
            }
            coinland = "";
            coinfliphead = 0;
            coinfliptails = 0;
            lblHeadsPoints.Text = lstcoinside[0] + " = ";
            lblTailsPoints.Text = lstcoinside[1] + " = ";
            lblWinner.Text = "";
            picCoin.BackgroundImage = imageList1.Images[0];
        }
        private void CheckWinner()
        {
            if (coinfliphead == 3 || coinfliptails == 3)
            {
                MessageBox.Show(coinland + " is the winner!!!");
                NewGame();
            }
        }
        private void CheckLanded()
        {
            lblWinner.Text = coinland;
            {
                if (coinland == lstcoinside[0])
                {
                    coinfliphead = coinfliphead + 1;
                    lblHeadsPoints.Text = coinland + " = " + coinfliphead.ToString();
                }
                if (coinland == lstcoinside[1])
                {
                    coinfliptails = coinfliptails + 1;
                    lblTailsPoints.Text = coinland + " = " + coinfliptails.ToString();
                }
            }
            CheckWinner();
        }
        private void FlipCoin()
        {
            int coinflip = rnd.Next(lstcoinside.Count);
            numtimesrotated = numtimesrotated + 1;
            SetCoin(coinflip);
        }
        private void SetCoin(int coinflip)
        {
            coinland = lstcoinside[coinflip];
            picCoin.BackgroundImage = imageList1.Images[coinflip];
        }
        private void RotateImage()
        {
            //set the image to the other image
            if (coinland == lstcoinside[0])
            {
                //sets coinland for the next tick of the timer
                //coinland = lstcoinside[1];
                ////changes the pic
                //picCoin.BackgroundImage = imageList1.Images[1];
                SetCoin(1);
            }
            else
            {
                //sets coinland for the next tick of the timer
                SetCoin(0);
            }
            //when the timer is turned off then call flip coin
            FlipCoin();
            if (numtimesrotated == flipincrement)
            {
                timerflipcoin.Enabled = false;
                numtimesrotated = 0;
                CheckLanded();
            }   
        }
        private void Timerflipcoin_Tick(object? sender, EventArgs e)
        {
            RotateImage();
        }
        private void Btnflipcoin_Click(object? sender, EventArgs e)
        {
            timerflipcoin.Enabled = true;
        }
    }
}

//