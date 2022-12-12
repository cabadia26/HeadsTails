using HeadsTailsApp;
using NUnit.Framework;
using static HeadsTailsApp.GameHeadsTails;

//CA had to make headpoints not private to unit test

namespace HeadsTailsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCheckLanded()
        {
            GameHeadsTails game = new GameHeadsTails();
            TestContext.WriteLine();
          
            game.SideLanded = CoinSideEnum.Heads;
            game.CheckLanded();
            Assert.IsTrue(game.HeadsPoints == 1);
        }
        [TestCase(CoinSideEnum.Heads)]
        public void TestSetWinnerMessage(CoinSideEnum side)
        {
            GameHeadsTails game = new GameHeadsTails();
            TestContext.WriteLine();
            game.NewGame();
            game.SideLanded = side;
            game.CheckLanded();
            game.SideLanded = side;
            game.CheckLanded();
            game.SideLanded = side;
            game.CheckLanded();
            {
                Assert.IsTrue(game.Message == side.ToString() + " is the winner!");
            }
        }
    }
}
//