using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClasePila
{
    [TestClass]
    public class PilaTest
    {
        [TestMethod]
        public void TestEsVaciaNulos()
        {
            Pila a = new Pila(8);
            Assert.IsTrue(a.esVacia());
        }

        [TestMethod]
        public void TestEsVacia()
        {
            Pila a = new Pila();
            Assert.IsTrue(a.esVacia());
        }

        [TestMethod]
        public void TestPop()
        {
            Pila a = new Pila();
            int x = 0;
            for (x=0; x < 10; x++) a.push(x);
            a.pop();
            bool expected = true;
            if ((int)a.miembros[0]==x)  expected=false;
            Assert.AreEqual(true,expected);
        }

        [TestMethod]
        public void TestPush()
        {
            Pila a = new Pila();
            a.push(1);
            a.push(2);
            bool expected=false;
            if (a.tamaño() == 2 && (int)a.miembros[0] == 2) expected = true;
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestPeek()
        {
            Pila a = new Pila();
            a.push(1);
            a.push(2);
            bool expected = false;
            if ((int)a.miembros[0] == 2) expected = true;
            Assert.IsTrue(expected);
        }
    }
}
