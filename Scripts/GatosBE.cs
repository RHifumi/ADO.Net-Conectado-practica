using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GatosBE : Object//Business entity es el modelo de tu dominio.
                         //Es decir son objetos que reflejan el mundo real o el problema que estás simulando
    {
        //Implemente mi constructor sin sobre cargas
        public GatosBE() { }

        //Inesescario pero implemento mi destructor
        ~GatosBE() { }

        /// <summary>Identificador único del gato.</summary>
        public int Id {  get; set; } //Añado el Get y Set como una propidad con accesos automaticos

        public override int GetHashCode() => Id.GetHashCode(); //Más robusto, GetHashCode puede contener más que enteros

        public override bool Equals(object obj) => obj is GatosBE g && g.Id == Id; //Obtengo el obj que recibi como parametro
        //Consulto si es un GatosBE si lo es lo declaro como g, y después lo comparo con mí ID

        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public bool EsMio { get; set; }

        public enum ColorGato
        {
            Gris,Negro, Rubio, Blanco_Negro
        }

        public ColorGato Color { get; set; }

        public override string ToString() => $"{Nombre}, de {Edad} años, color {Color}";


    }
}
