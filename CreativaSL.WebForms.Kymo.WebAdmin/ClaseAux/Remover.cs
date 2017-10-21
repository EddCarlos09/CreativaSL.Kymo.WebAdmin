using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux
{
    public class Remover
    {
        public static string RemoverSignosAcentos(string texto)
        {
            const string ConSignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜçÇ";
            const string SinSignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUcC";
            string textoSinAcentos = string.Empty;

            foreach (var caracter in texto)
            {
                var indexConAcento = ConSignos.IndexOf(caracter);
                if (indexConAcento > -1)
                    textoSinAcentos = textoSinAcentos + (SinSignos.Substring(indexConAcento, 1));
                else
                    textoSinAcentos = textoSinAcentos + (caracter);
            }
            textoSinAcentos = textoSinAcentos.Replace(" ", "-");
            textoSinAcentos = textoSinAcentos.ToLower();
            return textoSinAcentos;
        }

        public static string RemoverAcentos(string texto)
        {
            const string ConSignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜçÇ";
            const string SinSignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUcC";
            string textoSinAcentos = string.Empty;

            foreach (var caracter in texto)
            {
                var indexConAcento = ConSignos.IndexOf(caracter);
                if (indexConAcento > -1)
                    textoSinAcentos = textoSinAcentos + (SinSignos.Substring(indexConAcento, 1));
                else
                    textoSinAcentos = textoSinAcentos + (caracter);
            }
            textoSinAcentos = textoSinAcentos.ToLower();
            return textoSinAcentos;
        }
    }
}