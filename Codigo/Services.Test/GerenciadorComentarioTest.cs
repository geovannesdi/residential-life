﻿using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using Persistence;

namespace Services.Test
{
    
    
    /// <summary>
    ///This is a test class for GerenciadorComentarioTest and is intended
    ///to contain all GerenciadorComentarioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorComentarioTest
    {

        /*
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


        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            int idComentario = 0; // TODO: Initialize to an appropriate value
            target.Remover(idComentario);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ObterTodosPorPessoa
        ///</summary>
        [TestMethod()]
        public void ObterTodosPorPessoaTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            int idPessoa = 0; // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> actual;
            actual = target.ObterTodosPorPessoa(idPessoa);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> actual;
            actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterPorPostagemPessoa
        ///</summary>
        [TestMethod()]
        public void ObterPorPostagemPessoaTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            int idPostagem = 0; // TODO: Initialize to an appropriate value
            int idPessoa = 0; // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> actual;
            actual = target.ObterPorPostagemPessoa(idPostagem, idPessoa);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterPorPostagem
        ///</summary>
        [TestMethod()]
        public void ObterPorPostagemTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            int idPostagem = 0; // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<ComentarioModel> actual;
            actual = target.ObterPorPostagem(idPostagem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            int idComentario = 0; // TODO: Initialize to an appropriate value
            ComentarioModel expected = null; // TODO: Initialize to an appropriate value
            ComentarioModel actual;
            actual = target.Obter(idComentario);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            ComentarioModel comentarioModel = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Inserir(comentarioModel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void GetQueryTest()
        {
            GerenciadorComentario_Accessor target = new GerenciadorComentario_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<ComentarioModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<ComentarioModel> actual;
            actual = target.GetQuery();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarTest()
        {
            GerenciadorComentario target = new GerenciadorComentario(); // TODO: Initialize to an appropriate value
            ComentarioModel comentarioModel = null; // TODO: Initialize to an appropriate value
            target.Editar(comentarioModel);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Services.dll")]
        public void AtribuirTest()
        {
            GerenciadorComentario_Accessor target = new GerenciadorComentario_Accessor(); // TODO: Initialize to an appropriate value
            ComentarioModel comentarioModel = null; // TODO: Initialize to an appropriate value
            tb_comentario comentarioE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(comentarioModel, comentarioE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GerenciadorComentario Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorComentarioConstructorTest()
        {
            GerenciadorComentario target = new GerenciadorComentario();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorComentario Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorComentarioConstructorTest1()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorComentario target = new GerenciadorComentario(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        } */
    }
}