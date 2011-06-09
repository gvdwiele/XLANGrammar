using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Irony.Samples;
using Irony.Samples.Scheme;
using Irony.Parsing;
using Irony.Ast;
using Irony.Interpreter;
using BizTalk.Grammars;

namespace XLANGsGrammarTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class XLANGsTests
    {
        public XLANGsTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [DeploymentItem("Samples\\AtomicService.odx")]
        public void CanParseAtomicService()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("AtomicService.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\Compensation.odx")]
        public void CanParseCompensation()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("Compensation.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\ControlFlow.odx")]
        public void CanParseControlFlow()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("ControlFlow.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\InnerScopes.odx")]
        public void CanParseInnerScopes()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("InnerScopes.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\Iteration.odx")]
        public void CanParseIteration()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("Iteration.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }
        
        [TestMethod]
        [DeploymentItem("Samples\\Listen.odx")]
        public void CanParseListen()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("Listen.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\LongRunningService.odx")]
        public void CanParseLongRunningService()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("LongRunningService.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\NoShapes.odx")]
        public void CanParseNoShapes()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("NoShapes.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
            
        }

        [TestMethod]
        [DeploymentItem("Samples\\OrchestrationParams.odx")]
        public void CanParseOrchestrationParams()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("OrchestrationParams.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\ParallelActions.odx")]
        public void CanParseParallelActions()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("ParallelActions.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\ReceiveSend.odx")]
        public void CanParseReceiveSend()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("ReceiveSend.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\ScopeLocalFields.odx")]
        public void CanParseScopeLocalFields()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("ScopeLocalFields.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\SuspendTerminate.odx")]
        public void CanParseSuspendTerminate()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("SuspendTerminate.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\ThrowingAndCatching.odx")]
        public void CanParseThrowingAndCatching()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("ThrowingAndCatching.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        [TestMethod]
        [DeploymentItem("Samples\\Types.odx")]
        public void CanParseTypes()
        {
            //make a universal load method that reads the deploymentitem att
            string script = LoadFile("Types.odx");
            XLANGsGrammar grammar = new XLANGsGrammar();
            var tree = Parse(grammar, script, false);
        }

        private ParseTree Parse(Grammar grammar, string script, bool expectError, bool allowConflicts)
        {
            var language = new LanguageData(grammar);
            var parser = new Parser(language);
            var errors = parser.Language.Errors;
            StringBuilder errorDescription = new StringBuilder();
            ParseTree ast = null;

            //Grammar should always load
            if (errors.Count != 0 && allowConflicts==false)
            {
                foreach (var err in errors)
                {
                    errorDescription.AppendLine(string.Format("level:{0},message:{1},stat:{2}.", err.Level.ToString(), err.Message, err.State));
                }
                throw new Exception("Failure loading grammar: " + errorDescription.ToString());
            }

            try
            {
                ast = parser.Parse(script, "<source>");

                foreach (var err in ast.ParserMessages)
                    errorDescription.AppendLine(string.Format("location:{0},error:{1},parserstate:{2}.", err.Location, err, err.ParserState));

                if (expectError == false && ast.ParserMessages.Count > 0)
                    throw new Exception("Failure while parsing: " + errorDescription.ToString());

                if (expectError == true && ast.ParserMessages.Count == 0)
                    throw new Exception("Expected error was not thrown.");
            }
            catch (Exception)
            {
                if (expectError == false)
                    throw;

                //add exception type checking
            }


            return ast;
        }

        private ParseTree Parse(Grammar grammar, string script, bool expectError)
        {
            return Parse(grammar, script, expectError, false);
        }


        private string LoadFile(string path)
        {
            StreamReader reader = null;
            using (reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
