namespace ParallelWordFrequencyAnalyzer
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Application.SourcePath = args[0];
            Application.DestinationPath = args[1];
            Application.Run();
        }
    }
}
