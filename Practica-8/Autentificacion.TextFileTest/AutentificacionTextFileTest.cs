using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autentificacion.TextFile;
using Autentificador;

namespace Autentificacion.TextFile.Test
{
    [TestClass()]
    public class AutentificacionTextFileTest
    {
        private string ficheroClaves;
        private string CrearFichero(string nombreFichero)
        {
            string pathApp = System.Environment.CurrentDirectory;
            this.ficheroClaves = pathApp + "\\" + nombreFichero;
            using (StreamWriter sw = new StreamWriter(this.ficheroClaves))
            {
                for (int i = 1; i <= 9; i++)
                {
                    switch (i)
                    {
                        case 1: { sw.WriteLine("1;"+"Usuario" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "true" +';'); break; } //todo correcto
                        case 2: { sw.WriteLine("2;"+"Usuario" + i + ";" + "Password" + i + ";" + "" + ";" + "true" + ';'); break; } //todo corecto sin categoria
                        case 3: { sw.WriteLine("3;"+"Usuario" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "true" ); break; } // todo correcto sin ; final
                        case 4: { sw.WriteLine("4;" + "Usuario" + i + ";" + "Password" + i + ";" + "ALUMNO"); break; } // sin campo EsValido 
                        case 5: { sw.WriteLine("5;" + "Usuario" + i + ";;" + "Password" + i + ";;" + "ALUMNO" + ";;" + "true" ); break; } //formato mal
                        case 6: { sw.WriteLine("6;" + "Usuario" + i + ";" + "PasswordMAL" + i + ";" + "ALUMNO" + ";" + "true"+ ';'); break; } // passwor mal
                        case 7: { sw.WriteLine("77;" + "UsuarioMAL" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "true"+';'); break; } //id mal
                        case 8: { sw.WriteLine("8;" + "Usuario" + i + ";" + "PasswordMAL" + i + ";" + "ALUMNO" + ";" + "false"+ ';'); break; } //PASSWORD Y Es Valido mal 
                        case 9: { sw.WriteLine("99;" + "UsuarioMAL" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "false"+';'); break; } // Id y EsValido MAL 
                        
                    }
                }

            }
            return ficheroClaves;
        }


        private string CrearFicheroDuplicados(string nombreFichero)
        {
            string pathApp = System.Environment.CurrentDirectory;
            this.ficheroClaves = pathApp + "\\" + nombreFichero;
            using (StreamWriter sw = new StreamWriter(this.ficheroClaves))
            {
                for (int i = 1; i <= 10; i++)
                {
                    switch (i)
                    {
                        case 1: { sw.WriteLine("1;" + "Usuario" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "true" + ';'); break; } //todo correcto
                        case 2: { sw.WriteLine("2;" + "Usuario" + i + ";" + "Password" + i + ";" + "" + ";" + "true" + ';'); break; } //todo corecto sin categoria
                        case 3: { sw.WriteLine("3;" + "Usuario" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "true"); break; } // todo correcto sin ; final
                        case 4: { sw.WriteLine("4;" + "Usuario" + i + ";" + "Password" + i + ";" + "ALUMNO"); break; } // sin campo EsValido 
                        case 5: { sw.WriteLine("5;" + "Usuario" + i + ";;" + "Password" + i + ";;" + "ALUMNO" + ";;" + "true"); break; } //formato mal
                        case 6: { sw.WriteLine("6;" + "Usuario" + i + ";" + "PasswordMAL" + i + ";" + "ALUMNO" + ";" + "true" + ';'); break; } // passwor mal
                        case 7: { sw.WriteLine("77;" + "UsuarioMAL" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "true" + ';'); break; } //id mal
                        case 8: { sw.WriteLine("8;" + "Usuario" + i + ";" + "PasswordMAL" + i + ";" + "ALUMNO" + ";" + "false" + ';'); break; } //PASSWORD Y Es Valido mal 
                        case 9: { sw.WriteLine("99;" + "UsuarioMAL" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "false" + ';'); break; } // Id y EsValido MAL 
                        case 10: { sw.WriteLine("99;" + "UsuarioMAL" + i + ";" + "Password" + i + ";" + "ALUMNO" + ";" + "false" + ';'); break; } // duplicado

                    }
                }

            }
            return ficheroClaves;
        }

        [TestInitialize()]
        public void Init()
        {
            ficheroClaves = CrearFichero("claves.txt");
            //acceso = new AutentificacionTextFile(ficheroClaves);
        }


        [TestMethod()]
        public void TextFile_FicheroDuplicacoTest()
        {
            try
            {
                ficheroClaves = CrearFicheroDuplicados("clavesDuplicado.txt");
                AutentificacionTextFile accesoInvalido = new AutentificacionTextFile("clavesDuplicado.txt");
                Assert.Fail("Se esperaba una excepción de Autentificación con CodigoAutentificacion.ErrorDatos");
            }
            catch (AutentificacionExcepcion ex)
            {
                Assert.AreEqual(ex.Codigo, CodigoAutentificacion.ErrorDatos);
            }
            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }

        }




        //   [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\claves.txt", "claves#txt", DataAccessMethod.Sequential), DeploymentItem("TestClaseAccessoText\\claves.txt"), TestMethod()]
         [TestMethod()]
        public void TextFile_FicheroInvalidoTest()
        {
            try
            {
                AutentificacionTextFile accesoInvalido = new AutentificacionTextFile("ErrorFichero.txt");
            }
            catch (AutentificacionExcepcion ex)
            {
                Assert.AreEqual(ex.Codigo, CodigoAutentificacion.ErrorDatos);
            }
            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }

        }


        [TestMethod()]
        [ExpectedException(typeof(AutentificacionExcepcion))]
         public void TextFile_ExcepccionFicheroInvalidoTest()
        {
            AutentificacionTextFile accesoInvalido = new AutentificacionTextFile("ErrorFichero.txt");
        }

        [TestMethod()]
        public void TextFile_ControlAccesoTestVerdadero()
        {
            try
            {
                var acceso = new AutentificacionTextFile("claves.txt");
                for (int i = 1; i <= 3; i++)
                {
                    CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                    Assert.IsTrue(CodigoAutentificacion.AccesoCorrecto == codigo);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }


        [TestMethod()]
        public void TextFile_ControlAccesoTestErrorEsValido()
        {
            try
            {
                int i = 4;
                var acceso = new AutentificacionTextFile("claves.txt");
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue(CodigoAutentificacion.AccesoInvalido == codigo);
            }

            catch (AutentificacionExcepcion ex)
            {
                Assert.IsTrue(CodigoAutentificacion.ErrorDatos == ex.Codigo);
            }
            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }


        [TestMethod()]
        public void TextFile_ControlAccesoTestErrorPalabraPasoYEsValido()
        {
            try
            {
                int i = 5;
                var acceso = new AutentificacionTextFile("claves.txt");
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue((CodigoAutentificacion.ErrorPalabraPaso|CodigoAutentificacion.AccesoInvalido) == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFile_ControlAccesoTestErrorPalabraPaso()
        {
            try
            {
                int i = 6;
                var acceso = new AutentificacionTextFile("claves.txt");
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue(CodigoAutentificacion.ErrorPalabraPaso == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFile_ControlAccesoTestErrorId()
        {
            try
            {
                int i = 7;
                var acceso = new AutentificacionTextFile("claves.txt");
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue(CodigoAutentificacion.ErrorIdUsuario == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFile_ControlAccesoTestErrorPasswordYEsValido()
        {
            try
            {
                int i = 8;
                var acceso = new AutentificacionTextFile("claves.txt");
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue((CodigoAutentificacion.AccesoInvalido | CodigoAutentificacion.ErrorPalabraPaso) == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFile_ControlAccesoTestErrorIdYEsValido()
        {
            try
            {
                int i = 9;
                var acceso = new AutentificacionTextFile("claves.txt");
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue((CodigoAutentificacion.ErrorIdUsuario) == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

    }
}

