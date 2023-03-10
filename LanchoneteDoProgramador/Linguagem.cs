using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador
{
    public class Linguagem
    {
        private readonly ResourceManager rm;
        private readonly CultureInfo ci;

        public Linguagem(string idioma)
        {
            rm = new ResourceManager("LanchoneteDoProgramador.Resources.String", Assembly.GetExecutingAssembly());
            ci = CultureInfo.CreateSpecificCulture(idioma);
        }

        public string GetMensagem(string chave)
        {
            return rm.GetString(chave, ci);
        }
    }
}
