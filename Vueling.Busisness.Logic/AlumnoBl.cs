using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.model;
using Vueling.DataAccess.Dao;

namespace Vueling.Busisness.Logic
{
    public class AlumnoBl : IAlumnobL
    {
        private IAlumnoDao alumnodao;

        public Alumno Add(Alumno alumno, string format)
        {
            Alumno al;
            alumno.Edad = CalculoEdad(alumno.FechadeNacimiento);
            alumno.FechadeNacimiento = HoraRegistro();

            switch (format)
            {
                case "txt":
                    alumnodao = new AlumnoTxtDao();
                    al = alumnodao.Add(alumno);
                    break;
                case "json":
                    alumnodao = new AlumnoJsonDao();
                    al = alumnodao.Add(alumno);
                    break;
                case "xml":
                    alumnodao = new AlumnoXmlDao();
                    al = alumnodao.Add(alumno);
                    break;
                default:
                    throw new ArgumentException("Tipo de formato no correcto", "format");
            }

            return al;
        }

        private int CalculoEdad(DateTime fechaNacimiento)
        {
            DateTime CurrentDate = DateTime.Now;
            var edad = CurrentDate.Year - fechaNacimiento.Year;
            if (CurrentDate.Month < fechaNacimiento.Month || (CurrentDate.Month == fechaNacimiento.Month && CurrentDate.Day < fechaNacimiento.Day))
                edad--;
            return edad;
        }

        public DateTime HoraRegistro()
        {
            return DateTime.Now;
        }

    }
}
