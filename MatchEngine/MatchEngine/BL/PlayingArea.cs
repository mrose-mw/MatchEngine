namespace MatchEngine.BL
{

    /// <summary>
    /// The playing area.
    /// </summary>
    public class PlayingArea
    {

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets the goal area north.
        /// </summary>
        /// <value>
        /// The goal area north.
        /// </value>
        public GoalArea GoalAreaNorth { get; set; }

        /// <summary>
        /// Gets or sets the goal area south.
        /// </summary>
        /// <value>
        /// The goal area south.
        /// </value>
        public GoalArea GoalAreaSouth { get; set; }
    }
}
