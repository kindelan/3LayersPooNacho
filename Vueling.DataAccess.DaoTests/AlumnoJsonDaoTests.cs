using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Vueling.Common.Logic.model;
using Newtonsoft.Json;



namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class AlumnoJsonDaoTests
    {
        private readonly string path = (@"alumnos.json");
        private IAlumnoDao alumnojsondao;


        [TestInitialize]
        public void testInit()
        {
            alumnojsondao = new AlumnoJsonDao();

            if (File.Exists(path)) { File.Delete(path); }
        }

        [DataRow(1, "dd", "dd", "dd", "10-03-1888", 25)]
        [DataTestMethod]
        public void AddTest(int idAlumno, string name, string apellidos, string dni, string fechadenacimiento, int edad)
        {
            var fechaNac = Convert.ToDateTime(fechadenacimiento);
            Alumno alumno = new Alumno(name, apellidos, idAlumno, fechaNac, dni);
            alumno.Guid = System.Guid.NewGuid().ToString();
            alumno.Edad = edad;
            alumno.FechadeCreacion = DateTime.Now;

            alumnojsondao.Add(alumno);

            Alumno alumnotest = LeerAlumnoJson();
            Assert.IsTrue(alumno.Equals(alumnotest));
        }


        [TestCleanup]
        public void testClean()
        {
            //
        }

        private Alumno LeerAlumnoJson()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sw = new StreamReader(fs))
            {

                String json = sw.ReadToEnd();
                return JsonConvert.DeserializeObject<Alumno>(json);
            }
        }
    }
}