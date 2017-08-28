using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fwk.Bases;

namespace SaludHealth32.Common.BE
{
   
    public class PacienteList : Fwk.Bases.Entities<PacienteBE>
    {
    
    }
    

    public class PacienteBE : Fwk.Bases.Entity
    {
        int _Numref;
        string _Nombre;
        string _Apellidos;
        string _Documento;
        int _NumDocumento;
        string _FechaIngreso;
        string _EstadoCivil;
        string _Sexo;

        public PacienteBE()
        {

        }

        public int Numref
        {
            get { return _Numref; }
            set { _Numref = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        public int NumDocumento
        {
            get { return _NumDocumento; }
            set { _NumDocumento = value; }
        }


        public string FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }

        public string EstadoCivil
        {
            get { return _EstadoCivil; }
            set { _EstadoCivil = value; }
        }

        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }
    }
}
