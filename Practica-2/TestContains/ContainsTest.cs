using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BindingCollection
{
    [TestClass]
    public class ContainsTest
    {
        [TestMethod]
        public void ContainsEjercicio1BTest()
        {
            List<UsuarioView> lista = new List<UsuarioView>();
            UsuarioView a = new UsuarioView(1, "a", "b", "c");
            UsuarioView b = new UsuarioView(2, "b", "b", "n");
            UsuarioView c = new UsuarioView(3, "a", "b", "s");
            lista.Add(a);
            lista.Add(b);
            lista.Add(c);
            bool expected = true;
            bool real = lista.Contains(a);
            Assert.AreEqual(expected, real);
        }
    }
}
