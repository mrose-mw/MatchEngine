namespace MatchEngine.Test
{

    using System;

    using MatchEngine.BL;
    using MatchEngine.Enums;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The engine tests.
    /// </summary>
    [TestClass]
    public class EngineTests
    {

        /// <summary>
        /// The initialize engine test.
        /// </summary>
        [TestMethod]
        public void InitializeEngineTest()
        {
            // Arrange
            PlayerList playerList = new PlayerList { ListOfPlayers = new System.Collections.Generic.List<Player>() };

            Tactics tactics = new Tactics();
            
            TeamSelection home = new TeamSelection(playerList, Formation.FourFourOneOne, tactics);
            TeamSelection away = new TeamSelection(playerList, Formation.FourFourTwo, tactics);

            Ball ball = new Ball { XPosition = 10, YPosition = 0, ZPosition = 0, BallType = BallType.Round};
            PlayingArea playingArea = new PlayingArea { Height = 100, Width = 50, Length = 100, GoalAreaNorth = new GoalArea{Width = 10, Height = 8, Length = 5}, GoalAreaSouth = new GoalArea{Width = 10, Height = 8, Length = 5} };

            // Act
            Engine engine = new Engine(home, away,ball, playingArea);

            // Assert
            Assert.AreEqual(home, engine.HomeTeamSelection);
            Assert.AreEqual(away, engine.AwayTeamSelection);
        }

    }

}
