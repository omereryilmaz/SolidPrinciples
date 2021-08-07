using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibility
{
    public class PrintResult
    {
        private string Result { get; set; }

        public PrintResult(string _result)
        {
            this.Result = _result;
        }

        public void ToConsole()
        {
            Console.WriteLine(this.Result);
        }

        public void ToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(
                Path.Combine(directoryPath, fileName),
                this.Result
                );
        }
    }
}
