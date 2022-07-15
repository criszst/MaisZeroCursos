using System.Text.Json;
using SistemaMaisZeroCursos.Model;
using System.IO;
using System.Configuration;

namespace SistemaMaisZeroCursos.Arquivos
{
    public class ioFile
    {
        private string CaminhoArquivo { get; set; }

        public ioFile()
        {
            CaminhoArquivo = ConfigurationManager.AppSettings["Path"]!;

            if (!Directory.Exists(CaminhoArquivo))
            {
                Directory.CreateDirectory(CaminhoArquivo);
            }
        }
        public void GravarArquivo(string dadosJson, string name)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(CaminhoArquivo, $"{name}.json"), false))
            {
                sw.WriteLine(dadosJson);
            }
        }

        public string LerArquivo(string name)
        {
            var output = "";
            var nomeArquivo = Path.Combine(CaminhoArquivo, $"{name}.json");

            if (File.Exists(nomeArquivo)) {
                using (StreamReader reader = new StreamReader(nomeArquivo))
                {
                    output = reader.ReadToEnd();
                }
            }

            return output;
        }
    }
}
