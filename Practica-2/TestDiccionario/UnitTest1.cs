using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BindingCollection
{
    [TestClass]
    public class diccionarioTest
    {
        [TestMethod]
        public void agregarUsuariosMismoNombreDiccionario()
        {
            Dictionary<int,UsuarioView> usuarios = new Dictionary<int, UsuarioView>();
            UsuarioView a = new UsuarioView(1, "a", "b", "c");
            UsuarioView c = new UsuarioView(2, "a", "b", "c");
            usuarios.Add(int.Parse(a.id), a);
            usuarios.Add(int.Parse(c.id), c);
            bool expected = true;
            bool expected1 = usuarios.ContainsValue(a);
            bool expected2 = usuarios.ContainsValue(c);
            Assert.AreEqual(expected1,expected);
            Assert.AreEqual(expected2, expected);
        }

        [TestMethod]
        public void buscarUsuariosDiccionario()
        {
            Dictionary<int, UsuarioView> usuarios = new Dictionary<int, UsuarioView>();
            UsuarioView a = new UsuarioView(1, "a", "b", "c");
            UsuarioView b = new UsuarioView(2, "a", "b", "c");
            usuarios.Add(int.Parse(a.id), a);
            usuarios.Add(int.Parse(b.id), b);
            bool expectedTrue = true;
            bool expected1 = usuarios.TryGetValue(1,out a);
            bool expected2 = usuarios.TryGetValue(2, out b);
            Assert.AreEqual(expected1, expectedTrue);
            Assert.AreEqual(expected2, expectedTrue);
        }

        [TestMethod]
        public void agregarUsuariosMismoIdDiccionario()
        //En este test se espera que se produzca una excepcion al haber ya un Usuario 
        //con esa clave
        {
            Dictionary<int, UsuarioView> usuarios = new Dictionary<int, UsuarioView>();
            UsuarioView a = new UsuarioView(1, "a", "b", "c");
            UsuarioView b = new UsuarioView(1, "a", "b", "c");
            usuarios.Add(int.Parse(a.id), a);
            usuarios.Add(int.Parse(b.id), b);
            bool expectedFalse = false;
            bool expectedTrue = true;
            bool expected1 = usuarios.ContainsKey(int.Parse(a.id));
            bool expected2 = usuarios.ContainsKey(int.Parse(b.id));
            Assert.AreEqual(expected1, expectedTrue);
            Assert.AreEqual(expected2, expectedFalse);
        }
    }
}
