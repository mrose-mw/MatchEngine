namespace MatchEngine.BL
{
    
    /// <summary>
    /// The engine.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class.
        /// </summary>
        /// <param name="homeTeamSelection">
        /// The home Team Selection.
        /// </param>
        /// <param name="awayTeamSelection">
        /// The away Team Selection.
        /// </param>
        /// <param name="ball">
        /// The ball parameter.
        /// </param>
        /// <param name="playingArea">
        /// The playing Area.
        /// </param>
        public Engine(TeamSelection homeTeamSelection, TeamSelection awayTeamSelection, Ball ball, PlayingArea playingArea)
        {
            this.HomeTeamSelection = homeTeamSelection;
            this.AwayTeamSelection = awayTeamSelection;
            this.Ball = ball;
            this.PlayingArea = playingArea;
        }

        /// <summary>
        /// Gets or sets the home team selection.
        /// </summary>
        /// <value>
        /// The home team selection.
        /// </value>
        public TeamSelection HomeTeamSelection { get; set; }

        /// <summary>
        /// Gets or sets the away team selection.
        /// </summary>
        /// <value>
        /// The away team selection.
        /// </value>
        public TeamSelection AwayTeamSelection { get; set; }

        /// <summary>
        /// Gets or sets the ball.
        /// </summary>
        /// <value>
        /// The ball parameter.
        /// </value>
        public Ball Ball { get; set; }

        /// <summary>
        /// Gets or sets the playing area.
        /// </summary>
        /// <value>
        /// The playing area.
        /// </value>
        public PlayingArea PlayingArea { get; set; }

        /// <summary>
        /// Gets or sets the game.
        /// </summary>
        /// <value>
        /// The game property.
        /// </value>
        public Game Game { get; set; }

        /// <summary>
        /// The initialize game.
        /// </summary>
        public void SimulateGame()
        {
            Game game = new Game();
            game.Start(this);
        }
    }
}
