using System.IO;
using System.Text;
using TauCode.Dev.Instruments;
using TauCode.Extensions;
using TauCode.Utility;

namespace TauCode.Dev.Tests.Exe
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var program = new Program();
            program.Run();
        }

        private readonly string _baseDir;

        public Program()
        {
            _baseDir = @"C:\temp\!-oha";
        }

        private void Run()
        {
            FileUtility.PurgeDirectory(_baseDir);

            var origDirPath = Path.GetFullPath($@"{_baseDir}\01-orig");
            var destDirPath = Path.GetFullPath($@"{_baseDir}\02-dest");

            Directory.CreateDirectory(destDirPath);

            var zipBytes = this.GetType().Assembly.GetResourceBytes("sln-example.zip", true);

            ZipUtility.UnZip(zipBytes, origDirPath);


            var ide = new Ide();
            ide.LoadSolution(@$"{origDirPath}\Acme.Sample.sln");

            ide.RelocateSolutionStructureTo(destDirPath);
            //ide.SaveSolution();
        }
    }
}
