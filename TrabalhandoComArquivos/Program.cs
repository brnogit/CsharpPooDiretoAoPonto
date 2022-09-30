using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region File e FileInfo
            var file = @"pasta\texto.txt";

            if (!File.Exists(file))
            {
                File.CreateText(file);
            }

            var fileInfo = new FileInfo(file);

            Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de atualização: {fileInfo.LastWriteTime}");



            #endregion

            Console.ReadKey();
        }
    }
}
