using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF6MySqlCodeFirst.Models;
using System.Linq;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace EF6MySqlCodeFirst.Test
{
    /// <summary>
    /// Description résumée pour InitializerTest
    /// </summary>
    [TestClass]
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class InitializerTest
    {
        public InitializerTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
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

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestInitialize]
        public void TestSetUp()
        {
            MyInitializer db = new MyInitializer();
            System.Data.Entity.Database.SetInitializer(db);
        }

        [TestMethod]
        public void IsValideNomberOfData()
        {
            using (var context = new MyContext())
            {
                var livres = context.Livres.ToList();
                Assert.IsNotNull(livres);
                var nb = livres.Count();
                Assert.AreEqual(5, nb);
            }
        }
    }
}
