using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AppTarefas.Banco
{
    public static class Constants
    {
        public const string NomeBanco = "AppTarefa.db3";

        public static string CaminhoBanco
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, NomeBanco);
            }
        }
    }
}
