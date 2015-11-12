namespace MatchEngine
{

    using MatchEngine.BL;
    using MatchEngine.Enums;

    /// <summary>
    /// The team selection.
    /// </summary>
    public class TeamSelection
    {

        /// <summary>
        /// The player list.
        /// </summary>
        private readonly PlayerList playerList;

        /// <summary>
        /// The formation.
        /// </summary>
        private readonly Formation formation;

        /// <summary>
        /// The tactics.
        /// </summary>
        private readonly Tactics tactics;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSelection"/> class.
        /// </summary>
        /// <param name="playerList">
        /// The player list.
        /// </param>
        /// <param name="formation">
        /// The formation.
        /// </param>
        /// <param name="tactics">
        /// The tactics.
        /// </param>
        public TeamSelection(PlayerList playerList, Formation formation, Tactics tactics)
        {
            this.playerList = playerList;
            this.formation = formation;
            this.tactics = tactics;
        }

        /// <summary>
        /// Gets the formation.
        /// </summary>
        /// <value>
        /// The formation.
        /// </value>
        public Formation Formation
        {
            get
            {
                return this.formation;
            }
        }

        /// <summary>
        /// Gets the player list.
        /// </summary>
        /// <value>
        /// The player list.
        /// </value>
        public PlayerList PlayerList
        {
            get
            {
                return this.playerList;
            }
        }

        /// <summary>
        /// Gets the tactics.
        /// </summary>
        /// <value>
        /// The tactics.
        /// </value>
        public Tactics Tactics
        {
            get
            {
                return this.tactics;
            }
        }

    }

}
