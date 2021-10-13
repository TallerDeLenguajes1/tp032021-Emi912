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
        private string path = @"Cadetes";
        public Cadeteria MiCadeteria { get => miCadeteria; set => miCadeteria = value; }
        public DBTemp()
        {
            MiCadeteria = new Cadeteria("Sandwicheria de Chirola", "San Martin 426");
            if (File.Exists(path))
            {
                MiCadeteria = GetDatos();
            }
        }

        public void GuardarDatos()
        {
            
            string cadeteJson = JsonSerializer.Serialize(miCadeteria);


            using (FileStream miArchivo = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter strWriter = new StreamWriter(miArchivo))
                {
                    strWriter.Write(cadeteJson);
                    strWriter.Close();
                    strWriter.Dispose();
                }
            }

            MiCadeteria = GetDatos();
        }


        public Cadeteria GetDatos()
        {
            Cadeteria CadetesJson;
            try
            {
                if (File.Exists(path))
                {
                    using (FileStream miArchivo = new FileStream(path, FileMode.Open))
                    {
                        using (StreamReader strReader = new StreamReader(miArchivo))
                        {
                            string Cadetes = strReader.ReadToEnd();
                            CadetesJson = JsonSerializer.Deserialize<Cadeteria>(Cadetes);
                            MiCadeteria = CadetesJson;
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
