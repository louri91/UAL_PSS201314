using BindingCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace TestProjectControlUsuarios
{
    
    
    /// <summary>
    ///This is a test class for UsuarioTest and is intended
    ///to contain all UsuarioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UsuarioComparableTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        
        #region Test de objetos iguales
        

        ///</summary>
        [TestMethod()]
        // método CompareTo. Objetos iguales.
        public void CompareToSameObjectTest()
        {
            int i=1;
            string snum=i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );
            UsuarioView userB = userA;

            int expected = 0;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //método Compare. Objetos iguales.
        public void CompareSameObjectTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum );
            UsuarioView userB = userA;

            int expected = 0;
            int actual = userA.Compare(userA,userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador >= . Objetos iguales.
        public void OperatorMayorIgualSameObjectTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            UsuarioView userB = userA;

            bool expected = true;
            bool actual = userA >= userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador > . Objetos iguales.
        public void OperatorMayorSameObjectTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            UsuarioView userB = userA;

            bool expected = false;
            bool actual = userA > userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador < . Objetos iguales.
        public void OperatorMenorSameObjectTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum );

            UsuarioView userB = userA;

            bool expected = false;
            bool actual = userA < userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador <= . Objetos iguales.
        public void OperatorMenorIgualSameObjectTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            UsuarioView userB = userA;

            bool expected = true;
            bool actual = userA <= userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion





        #region Test de valores iguales


        ///</summary>
        [TestMethod()]
        // método CompareTo. Valores iguales.
        public void CompareToSameValueTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum );
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum );

            int expected = 0;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //método Compare. Valores iguales.
        public void CompareSameValueTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            int expected = 0;
            int actual = userA.Compare(userA, userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador >= . Valores iguales.
        public void OperatorMayorIgualSameValueTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA >= userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador > . Valores iguales.
        public void OperatorMayorSameValueTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA > userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador < . Valores iguales.
        public void OperatorMenorSameValueTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA < userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador <= . Valores iguales.
        public void OperatorMenorIgualSameValueTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA <= userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion


        #region Comparación de valores Mayores por la derecha
       

        ///</summary>
        [TestMethod()]
        //método CompareTo. Valores mayor derecha
        public void CompareToMayorDerechaTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum );

            int expected = -1;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //método Compare. Valores mayor derecha
        public void CompareMayorDerechaTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            int expected = -1;
            int actual = userA.Compare(userA, userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador >= .Valores mayor derecha
        public void OperatorMayorIgualDerechaTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA >= userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador > .Valores mayor derecha
        public void OperatorMayorDerechaTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA > userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador < . Valores mayor derecha
        public void OperatorMenorDerechaTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA < userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador <= . Valores mayor derecha
        public void OperatorMenorIgualDerechaTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA <= userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion


        #region Comparación de valores Mayores por la izquierda


        ///</summary>
        [TestMethod()]
        //método CompareTo. Valores mayor izquierda.
        public void CompareToMayorIquierdaTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            int expected = 1;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //método Compare. Valores mayor izquierda.
        public void CompareMayorIzquierdaTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            int expected = 1;
            int actual = userA.Compare(userA, userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador >= . Valores mayor izquierda.
        public void OperatorMayorIgualIzquierdaTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA >= userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador > . Valores mayor izquierda
        public void OperatorMayorIzquierdaTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA > userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador < . Valores mayor izquierda.
        public void OperatorMenorIzquierdaTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA < userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador <= . Valores mayor izquierda.
        public void OperatorMenorIgualIzquierdaTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA <= userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion






        #region Comparación de valoresNulos por la izquierda


        ///</summary>
        [TestMethod()]
        //método CompareTo. Valores nulos izquierda.
        public void CompareToMayorIquierdaNullTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );
          
            UsuarioView userB = null;

            int expected = 1;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //método Compare. Valores nulos izquierda.
        public void CompareMayorIzquierdaNullTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            UsuarioView userA = null;

            int expected = -1;
            int actual = userB.Compare(userA, userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador >= . Valor null izquierda.
        public void OperatorMayorIgualIzquierdaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA >= userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador > . Valores null izquierda
        public void OperatorMayorIzquierdaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userA > userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador < . Valores null izquierda.
        public void OperatorMenorIzquierdaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA < userB;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador <= . Valores null izquierda.
        public void OperatorMenorIgualIzquierdaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userA <= userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion






        #region Comparación de valoresNulos por la derecha


        ///</summary>
        [TestMethod()]
        //método CompareTo. Valores nulos izquierda.
        public void CompareToMayorDerechaNullTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            UsuarioView userB = null;

            int expected = 1;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //método Compare. Valores nulos derecha.
        public void CompareMayorDrechaNullTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            UsuarioView userA = null;

            int expected = 1;
            int actual = userB.Compare(userB,userA);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador >= . Valor null drecha.
        public void OperatorMayorIgualDerechaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;
            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userB >= userA;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador > . Valores null drerecha
        public void OperatorMayorDerechaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = true;
            bool actual = userB > userA;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador < . Valores null derecha.
        public void OperatorMenorDerechaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userB < userA;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador <= . Valores null derecha.
        public void OperatorMenorIgualDerechaNullTest()
        {
            int i = 2;
            string snum = i.ToString();
            UsuarioView userA = null;

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            bool expected = false;
            bool actual = userB <= userA;
            Assert.AreEqual(expected, actual);

        }
        #endregion




        #region Comparación de valoresNulos ambos


     
        ///</summary>
        [TestMethod()]
        //método Compare. Valores ambos nulos .
        public void CompareMayorBothNullTest()
        {

            UsuarioView userB = null;

            UsuarioView userA = null;
            int i = 2;
            string snum = i.ToString();
            UsuarioView userC  = new UsuarioView(i, "nombre_" + snum, "palabrapaso_" + snum, "roll_" + snum  );

            int expected = 0;
            int actual = userC.Compare(userB, userA);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador >= . Valor ambos null.
        public void OperatorMayorIgualBothNullTest()
        {
            UsuarioView userB = null;

            UsuarioView userA = null;

            bool expected = true;
            bool actual = userB >= userA;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador > . Valores ambos null
        public void OperatorMayorBothNullTest()
        {
            UsuarioView userB = null;

            UsuarioView userA = null;

            bool expected = false;
            bool actual = userB > userA;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador < . Valores ambos null
        public void OperatorMenorAmbosNullTest()
        {
            UsuarioView userB = null;

            UsuarioView userA = null;



            bool expected = false;
            bool actual = userB < userA;
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador <= . Valores ambos null
        public void OperatorMenorIgualAmbosNullTest()
        {
            UsuarioView userB = null;

            UsuarioView userA = null;


            bool expected = true;
            bool actual = userB <= userA;
            Assert.AreEqual(expected, actual);

        }
        #endregion

        

    }
}
