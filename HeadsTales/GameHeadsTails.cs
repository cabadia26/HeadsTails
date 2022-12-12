using HeadsTailsApp;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HeadsTailsApp
{
    public class GameHeadsTails : INotifyPropertyChanged
    {
        public enum CoinSideEnum { None = -1, Heads = 0, Tails = 1 };

        CoinSideEnum currentside = CoinSideEnum.None;
        string messageval = "";
        int hpval = 0;
        int tpval = 0;
        string headsdesc = "";
        string tailsdesc = "";

        public event PropertyChangedEventHandler? PropertyChanged;
        public GameHeadsTails()
        {
            this.SideLanded = CoinSideEnum.Heads;
            this.Message = "";
            SetUpHeadsCoin();
            SetUpTalesCoin();
            NewGame();
        }
        public void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        private Coin SetUpHeadsCoin()
        {
            Coin c = new();
            c.CoinSide = Coin.CoinSideEnum.Heads;
            return this.Heads = c;
        }
        private Coin SetUpTalesCoin()
        {
            Coin c = new();
            c.CoinSide = Coin.CoinSideEnum.Heads;
            return this.Tails = c;
        }
        public void NewGame()
        {
            HeadsPoints = 0;
            TailsPoints = 0;
            GameActive = true;
            SideLanded = CoinSideEnum.Heads;
            Message = "";
            HeadsDesc = HeadsDesc + " " + HeadsPoints;
            TailsDesc = TailsDesc + " " + TailsPoints;
        }
        public void CheckLanded()
        {
          
            if (SideLanded == CoinSideEnum.Heads)
            {
                this.HeadsPoints ++;
                HeadsDesc = HeadsDesc + " " + HeadsPoints;
            }
            if (SideLanded == CoinSideEnum.Tails)
            {
                this.TailsPoints ++;
                TailsDesc = TailsDesc + " " + TailsPoints;
            }
            if (HeadsPoints == 3 || TailsPoints == 3)
            {
                GameActive = false;
                this.Message = SideLanded.ToString() + " is the winner!";
            }
            if (HeadsPoints > 3 || TailsPoints > 3)
            {
                throw new Exception("Game HeadsPoints/TailsPoints cannot exceed 3.");
            }
        }
        public string Message
        { get
            {
                return messageval;
            }
            private set
            {
                messageval = value;
                InvokePropertyChanged();
            }
        }
        public void SetSideLanded()
        {
            Random rnd = new Random();
            this.SideLanded = (CoinSideEnum)rnd.Next(0, 2);
        }
        public bool GameActive { get; private set; }
        public CoinSideEnum   SideLanded
        {
            get
            {
                return currentside;
            }
            set
            {
                currentside = value;
                InvokePropertyChanged();
            }
        }
        public string HeadsDesc
        {
            get
            {
                return headsdesc;
            }
            set 
            {
                headsdesc = "Heads =  " + HeadsPoints;
                InvokePropertyChanged();
            }
        }
        public string TailsDesc
        {
            get
            {
                return tailsdesc;
            }
            set
            {
                tailsdesc = "Tails =  " + TailsPoints;
                InvokePropertyChanged();
            }
        }
        public int HeadsPoints { get; private set;}
        public int TailsPoints { get; private set; }
        public Coin Heads { get; private set; }
        public Coin Tails { get; private set; }
        public int NumTimesRotated { get; set; }
    }
}
//