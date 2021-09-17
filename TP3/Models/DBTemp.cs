using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace TP3.Models
{
    public class DBTemp
    {
        private Cadeteria miCadeteria;
        public Cadeteria MiCadeteria { get => miCadeteria; set => miCadeteria = value; }
        public DBTemp()
        {
            MiCadeteria = new Cadeteria("Sandwicheria de Chirola", "San Martin 426");
        }

        public void GuardarCadetes()
        {
            string path = @"Cadetes";
            string cadeteJson = JsonSerializer.Serialize(miCadeteria.ListadoCadetes);


            using (FileStream miArchivo = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter strWriter = new StreamWriter(miArchivo))
                {
                    strWriter.Write(cadeteJson);
                    strWriter.Close();
                    strWriter.Dispose();
                }
            }

        }


        public Cadeteria GetCadetes()
        {
            List<Cadete> CadetesJson = null;
            try
            {
                string path = @"Cadetes";
                if (File.Exists(path))
                {
                    using (FileStream miArchivo = new FileStream(path, FileMode.Open))
                    {
                        using (StreamReader strReader = new StreamReader(miArchivo))
                        {
                            string Cadetes = strReader.ReadToEnd();
                            CadetesJson = JsonSerializer.Deserialize<List<Cadete>>(Cadetes);
                            MiCadeteria.ListadoCadetes = CadetesJson;
                        }
                    }
                }


            }
            catch (Exception e)
            {
                string error = e.ToString();
            }

          
            return MiCadeteria;

        }


    }
}
