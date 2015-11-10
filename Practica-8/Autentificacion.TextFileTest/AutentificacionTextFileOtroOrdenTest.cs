using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autentificacion.TextFile;
using Autentificador;
using BindingCollection;

namespace Autentificacion.TextFileOtroOrden.Test
{
    [TestClass()]
    public class AutentificacionTextFileTest
    {
        private string _ficheroClaves;
        private string _separador;
        private FormatoRegistro _formato = new FormatoRegistro(new CamposRegistro [] {CamposRegistro.Nombre,CamposRegistro.Id,CamposRegistro.PalabraPaso,CamposRegistro.Categoria,CamposRegistro.EsValido});
        private void CrearFichero(string nombreFichero)
        {
            string pathApp = System.Environment.CurrentDirectory;
            _ficheroClaves = pathApp + "\\" + nombreFichero;
            using (StreamWriter sw = new StreamWriter(_ficheroClaves))
            {
                for (int i = 1; i <= 9; i++)
                {
                    switch (i)
                    {
                        case 1: { sw.WriteLine("Usuario" + i + _separador +"1"+_separador+ "Password" + i + _separador + "ALUMNO" +_separador + "true" +_separador); break; } //todo correcto
                        case 2: { sw.WriteLine("Usuario" + i + _separador +"2"+_separador+ "Password" + i + _separador+  "" + _separador+ "true" + _separador); break; } //todo corecto sin categoria
                        case 3: { sw.WriteLine("Usuario" + i + _separador + "3" + _separador + "Password" + i + _separador + "ALUMNO" + _separador + "true"); break; } // todo correcto sin ; final
                        case 4: { sw.WriteLine("Usuario" + i + _separador + "4" + _separador + "Password" + i + _separador + "ALUMNO"); break; } // sin campo EsValido 
                        case 5: { sw.WriteLine( "Usuario" + i + _separador+_separador +"5" +_separador+ "Password" + i +_separador+_separador+ "ALUMNO" + _separador+_separador + "true" ); break; } //formato mal
                        case 6: { sw.WriteLine( "Usuario" + i + _separador+"6" +_separador+ "PasswordMAL" + i + _separador+ "ALUMNO" + _separador+ "true"+ _separador); break; } // passwor mal
                        case 7: { sw.WriteLine( "UsuarioMAL" + i + _separador +"77" +_separador+ "Password" + i + _separador+ "ALUMNO" + _separador+ "true"+_separador); break; } //id mal
                        case 8: { sw.WriteLine( "Usuario" + i + _separador+"8" +_separador+ "PasswordMAL" + i + _separador+ "ALUMNO" + _separador+ "false"+ _separador); break; } //PASSWORD Y Es Valido mal 
                        case 9: { sw.WriteLine( "UsuarioMAL" + i + _separador+"99" +_separador+ "Password" + i + _separador+ "ALUMNO" + _separador+ "false"+_separador); break; } // Id y EsValido MAL 
                        
                    }
                }

            }
        }


       

        [TestInitialize()]
        public void Init()
        {
            _separador = ";;;";
             CrearFichero("clavesOtroOrden.txt");
        }


       
          [TestMethod()]
        public void TextFileOtroOrden_FicheroInvalidoTest()
        {
            try
            {
                AutentificacionTextFile accesoInvalido = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
            }
            catch (AutentificacionExcepcion ex)
            {
                Assert.AreEqual(ex.Codigo ,CodigoAutentificacion.ErrorDatos);
            }

        }



        [TestMethod()]
        public void TextFileOtroOrden_ControlAccesoTestVerdadero()
        {
            try
            {
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                for (int i = 1; i <= 3; i++)
                {
                    CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                    Assert.IsTrue(CodigoAutentificacion.ErrorDatos == codigo);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }


        [TestMethod()]
        public void TextFileOtroOrden_ControlAccesoTestErrorEsValido()
        {
            try
            {
                int i = 4;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue(CodigoAutentificacion.AccesoInvalido == codigo);
            }

            catch (AutentificacionExcepcion ex)
            {
                Assert.IsTrue(CodigoAutentificacion.ErrorDatos == ex.Codigo);
            }
        }


        [TestMethod()]
        public void TextFileOtroOrden_ControlAccesoTestErrorId()
        {
            try
            {
                int i = 5;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue(CodigoAutentificacion.ErrorIdUsuario == codigo);
            }
            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFileOtroOrden_ControlAccesoTestErrorPalabraPaso()
        {
            try
            {
                int i = 6;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue(CodigoAutentificacion.ErrorPalabraPaso == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFileOtroOrden_ControlAccesoTestErrorIdFormato()
        {
            try
            {
                int i = 7;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue(CodigoAutentificacion.ErrorIdUsuario == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFileOtroOrden_ControlAccesoTestErrorPasswordYEsValido()
        {
            try
            {
                int i = 8;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue((CodigoAutentificacion.AccesoInvalido | CodigoAutentificacion.ErrorPalabraPaso) == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFileOtroOrden_ControlAccesoTestErrorIdYEsValido()
        {
            try
            {
                int i = 9;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                Assert.IsTrue((CodigoAutentificacion.ErrorIdUsuario) == codigo);
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFileOtroOrden_ModificarRegistro()
        {
            try
            {
                int i = 1;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                if (codigo != CodigoAutentificacion.AccesoCorrecto) Assert.Fail("Se esperaba Codigo de autentificación correcto");
                var user = new UsuarioView("1","Usuario__" + i, "Password__" + i, "ALUMNO", "true");
                acceso.ModificarUsuario(i.ToString(), user);
                CodigoAutentificacion codigoMod = acceso.EsUsuarioAutentificado(i.ToString(), "Password__" + i);
                if (codigo != CodigoAutentificacion.AccesoCorrecto) Assert.Fail("Se esperaba Codigo de autentificación correcto en la modificacion.");
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

        [TestMethod()]
        public void TextFileOtroOrden_GuardarModificado()
        {
            try
            {
                int i = 1;
                var acceso = new AutentificacionTextFile("clavesOtroOrden.txt", _formato, _separador);
                CodigoAutentificacion codigo = acceso.EsUsuarioAutentificado(i.ToString(), "Password" + i);
                if (codigo != CodigoAutentificacion.AccesoCorrecto) Assert.Fail("Se esperaba Codigo de autentificación correcto");
                var user = new UsuarioView("1", "Usuario__" + i, "Password__" + i, "ALUMNO", "true");
                acceso.ModificarUsuario(i.ToString(), user);
                CodigoAutentificacion codigoMod = acceso.EsUsuarioAutentificado(i.ToString(), "Password__" + i);
                if (codigoMod != CodigoAutentificacion.AccesoCorrecto) Assert.Fail("Se esperaba Codigo de autentificación correcto en la modificacion.");


                string ficheroModificado = "clavesOtroOrdenSaved.txt";
                acceso.GuardarDatos(ficheroModificado);
                
                var accesoSaved = new AutentificacionTextFile(ficheroModificado, _formato, _separador);
                codigoMod = accesoSaved.EsUsuarioAutentificado(i.ToString(), "Password__" + i);
                if (codigoMod != CodigoAutentificacion.AccesoCorrecto) Assert.Fail("Se esperaba Codigo de autentificación correcto en la modificacion.");
               
                
            }

            catch (Exception ex)
            {
                Assert.Fail("No se esperaba la excepcion: " + ex.Message);
            }
        }

    }
}

