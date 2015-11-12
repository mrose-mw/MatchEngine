namespace MatchEngine.BL
{

    /// <summary>
    /// The ball class.
    /// </summary>
    public class Ball
    {
        /// <summary>
        /// Gets or sets the x position.
        /// </summary>
        /// <value>
        /// The x position.
        /// </value>
        public int XPosition { get; set; }

        /// <summary>
        /// Gets or sets the y position.
        /// </summary>
        /// <value>
        /// The y position.
        /// </value>
        public int YPosition { get; set; }

        /// <summary>
        /// Gets or sets the z position.
        /// </summary>
        /// <value>
        /// The z position.
        /// </value>
        public int ZPosition { get; set; }

        /// <summary>
        /// Gets or sets the ball type.
        /// </summary>
        /// <value>
        /// The ball type.
        /// </value>
        public BallType BallType { get; set; }

        /// <summary>
        /// Gets or sets the movement speed.
        /// </summary>
        /// <value>
        /// The movement speed.
        /// </value>
        public float MovementSpeed { get; set; }



    }

}
