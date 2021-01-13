using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wCdT
{
    class CTirador
    {

        private string dni;
        private string apellido1;
        private string apellido2;
        private string nombre;
        private string empleo;
        private string uco;
        private string cia;
        private string pn;
        private string sc;

        /*====================================================
         * Constructores
         * ===================================================*/

        public CTirador()
        {
        }

        public CTirador(string dni, string apellido1, string apellido2, string nombre, string empleo, string uco, string cia, string pn, string sc)
        {
            this.dni = dni;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.nombre = nombre;
            this.empleo = empleo;
            this.uco = uco;
            this.cia = cia;
            this.pn = pn;
            this.sc = sc;
        }

        /*====================================================
         * Setters y getters
         * ===================================================*/


        public string Dni { get => dni; set => dni = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Empleo { get => empleo; set => empleo = value; }
        public string Uco { get => uco; set => uco = value; }
        public string Cia { get => cia; set => cia = value; }
        public string Pn { get => pn; set => pn = value; }
        public string Sc { get => sc; set => sc = value; }

        
    }







}
