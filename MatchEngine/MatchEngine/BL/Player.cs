namespace MatchEngine.BL
{
    /// <summary>
    /// The player.
    /// </summary>
    public class Player
    {

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has ball.
        /// </summary>
        /// <value>
        /// The has ball.
        /// </value>
        public bool HasBall { get; set; }

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
        /// Gets or sets the movement speed.
        /// </summary>
        /// <value>
        /// The movement speed.
        /// </value>
        public float MovementSpeed { get; set; }

        /// <summary>
        /// Gets or sets the angle of direction.
        /// </summary>
        /// <value>
        /// The angle of direction.
        /// </value>
        public int AngleOfDirection { get; set; }
    }

}
