using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public abstract class FileGenerator
    {
        public string WorkingDirectory => ConfigurationManager.AppSettings["WorkingDirectory"];

        public FileGenerator(string fileExtension)
        {
            FileExtension = fileExtension;
        }

        public string FileExtension { get; private set; }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        protected abstract byte[] GenerateFileContent(int contentLength);

        protected abstract void WriteBytesToFile(string fileName, byte[] content);
    }
}
