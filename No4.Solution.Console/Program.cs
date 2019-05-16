namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytesGenerator = new RandomBytesFileGenerator();
            bytesGenerator.GenerateFiles(3, 10);

            var charsGenerator = new RandomCharsFileGenerator();
            charsGenerator.GenerateFiles(3, 10);
        }
    }
}
