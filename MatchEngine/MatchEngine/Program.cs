namespace MatchEngine
{

    using MatchEngine.BL;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The main program.
        /// </summary>
        /// <param name="args">
        /// The arguments.
        /// </param>
        static void Main(TeamSelection[] args)
        {
            Engine engine = new Engine();
            engine.InitializeGame(args[0], args[1]);
        }

    }

}
