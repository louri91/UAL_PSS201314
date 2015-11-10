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
    public class UsuarioIgualdadTest
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
        //sobre-escritura del metodo Equals. Objetos iguales.
        public void ObjectEqualsSameTest()
        {
            int i=1;
            string snum=i.ToString();
            IUsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum);
            IUsuarioView userB = userA;

            bool expected = true;
            bool actual = userA.Equals(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //metodo Equals statico de object. Objetos iguales.
        public void StaticObjectEqualSameTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            UsuarioView userB = userA;

            bool expected = true;
            bool actual = Equals(userA,userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador == . Valores iguales (en objetos distintos) 
        public void OperatorEqualsSameTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            UsuarioView userB = userA;

            bool expected = true;
            bool actual = userA == userB;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        //sobre-escritura del operador != . Valores iguales (en objetos distintos) 
        public void OperatorNotEqualsSameTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            UsuarioView userB = userA;

            bool expected = false;
            bool actual = userA != userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion




        #region Test de valores iguales
        

        ///</summary>
        [TestMethod()]
        //sobre-escritura del metodo Equals. Valores iguales (en objetos distintos) 
        public void ObjectEqualsOtherTest()
        {
            int i=1;
            string snum=i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i=1;
            snum=(i+1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            bool expected = true;
            bool actual = userA.Equals(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //metodo Equals statico de object. Valores iguales (en objetos distintos) 
        public void StaticObjectEqualsOtherTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 1;
            snum = (i+1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            bool expected = true;
            bool actual = object.Equals(userA,userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador == . Valores iguales (en objetos distintos) 
        public void OperatorEqualsOtherTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            bool expected = true;
            bool actual = userA == userB;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        //sobre-escritura del operador != . Valores iguales (en objetos distintos) 
        public void OperatorNotEqualsOtherTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = userA != userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion


        #region Test de valores distintos por la izquierda


        ///</summary>
        [TestMethod()]
        //sobre-escritura del metodo Equals. Valores distintos (en objetos distintos) 
        public void ObjectNotEqualTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = userA.Equals(userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //metodo Equals statico de object. Valores distintos (en objetos distintos) 
        public void StaticObjectNotEqualsTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            bool expected = false;
            bool actual = object.Equals(userA, userB);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador == . Valores distintos (en objetos distintos) 
        public void OperatorEqualDifferentsTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = userA == userB;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        //sobre-escritura del operador != . Valores distintos (en objetos distintos) 
        public void OperatorDesEqualsDifferentTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = true;
            bool actual = userA != userB;
            Assert.AreEqual(expected, actual);

        }
        #endregion


        #region Test de valores distintos por la derecha


        ///</summary>
        [TestMethod()]
        //sobre-escritura del metodo Equals. Valores distintos (en objetos distintos) 
        public void EqualsObjectTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = userB.Equals(userA);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //metodo Equals statico de object. Valores distintos (en objetos distintos) 
        public void StaticEqualsObjectTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = object.Equals(userB, userA);
            Assert.AreEqual(expected, actual);

        }
        ///</summary>
        [TestMethod()]
        //sobre-escritura del operador == . Valores distintos (en objetos distintos) 
        public void EqualOperatorTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = userB == userA;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        //sobre-escritura del operador != . Valores distintos (en objetos distintos) 
        public void DesEqualOperatorTest()
        {
            int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 2;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            bool expected = true;
            bool actual = userB != userA;
            Assert.AreEqual(expected, actual);

        }
        #endregion

       
        #region Test de valores nulos 
        ///</summary>
        [TestMethod()]
        //sobre-escritura del metodo Equals. 
        public void EqualObjectNullTest()
        {

            UsuarioView userA = null;

            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = userB.Equals(userA);
            Assert.AreEqual(expected, actual);

        }

        
        ///</summary>
        [TestMethod()]
        //metodo Equals statico de object. valor nulo derecha 
        public void StaticObjectEqualNullRightTest()
        {

            UsuarioView userA = null;

            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = Equals(userB,userA);
            Assert.AreEqual(expected, actual);

        }


        ///</summary>
        [TestMethod()]
        //metodo Equals statico de object. valor nulo izquierda 
        public void StaticObjectEqualNullLeftTest()
        {

            UsuarioView userA = null;

            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = Equals(userA, userB);
            Assert.AreEqual(expected, actual);

        }

         ///</summary>
        [TestMethod()]
        //metodo Equals statico de object. valor nulo en ambos 
        public void StaticObjectEqualNullBothTest()
        {

            UsuarioView userA = null;
            UsuarioView userB = null;
           

            bool expected = true;
            bool actual = Equals(userA, userB);
            Assert.AreEqual(expected, actual);

        }

        ///</summary>
        [TestMethod()]
        //operador == . valor nulo izquierda 
        public void OperatorEqualNullLeftTest()
        {

            UsuarioView userA = null;

            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual = userA == userB;
            Assert.AreEqual(expected, actual);

        }

         ///</summary>
        [TestMethod()]
        //operador == . valor nulo derecha 
        public void OperatorEqualNullRightTest()
        {

            UsuarioView userA = null;

            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = false;
            bool actual =  userB == userA;
            Assert.AreEqual(expected, actual);

        }

                   ///</summary>
        [TestMethod()]
        //operador == . ambos nulos
        public void OperatorEqualNullBothTest()
        {

            UsuarioView userA = null;
            UsuarioView userB = null;

            bool expected = true;
            bool actual =  userB == userA;
            Assert.AreEqual(expected, actual);

        }
         ///</summary>
        [TestMethod()]
        //operador != . valor nulo izquierda 
        public void OperatorNotEqualNullLeftTest()
        {

            UsuarioView userA = null;

            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = true;
            bool actual = userA != userB;
            Assert.AreEqual(expected, actual);

        }

         ///</summary>
        [TestMethod()]
        //operador != . valor nulo derecha 
        public void OperatorNotEqualNullRigthTest()
        {

            UsuarioView userA = null;

            int i = 1;
            string snum = i.ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            bool expected = true;
            bool actual =  userB != userA;
            Assert.AreEqual(expected, actual);

        }


          ///</summary>
        [TestMethod()]
        //operador != . ambos nulos
        public void OperatorNotEqualNullBothTest()
        {

            UsuarioView userA = null;
            UsuarioView userB = null;

            bool expected = false;
            bool actual =  userB != userA;
            Assert.AreEqual(expected, actual);

        }

       

        #endregion


        #region Hashcodes
           ///</summary>
        [TestMethod()]
        //metodo getHashCode. el mismo valor en objetos distintos  
        public void hashCodeEqualsTest()
        {

             int i = 1;
            string snum = i.ToString();
            UsuarioView userA = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum  );

            i = 1;
            snum = (i + 1).ToString();
            UsuarioView userB = new UsuarioView ( i,"nombre_"+snum, "palabrapaso_"+snum, "roll_"+snum );

            int expected = userA.GetHashCode();
            int actual = userB.GetHashCode();

            Assert.AreEqual(expected, actual);

        }
        #endregion

        

    }
}
