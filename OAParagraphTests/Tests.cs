using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OAParagraph;
using System;

namespace OAParagraphTests
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Tests an Empty String
        /// </summary>
        [TestMethod]
        public void EmptyString()
        {

            Dictionary<string, int> results = Helper.CountWords(string.Empty);
            Assert.IsTrue(results.Count == 0);
        }

        /// <summary>
        /// Tests 1 2 3 4
        /// </summary>
        [TestMethod]
        public void OneTwoThreeFour()
        {
            string input = "one two two three three three four four four four hello oncology analytics";
            Dictionary<string, int> results = Helper.CountWords(input);
            Assert.IsTrue(results["one"] == 1 && results["two"] == 2 && results["three"] == 3 && results["four"] == 4);
        }

        /// <summary>
        /// Tests a paragraph from OA Website
        /// </summary>
        [TestMethod]
        public void ParagraphFromOAWebsite()
        {
            //simple, just check for exception, more tests can be added later
            string input = "Oncology Analytics is a different kind of partner for oncology utilization management. We provide access to current, evidence-based, disease-specific analytics on all cancer types and treatment options, backed by board-certified oncology physicians and pharmacists. Our data science teams utilize advanced data models and machine learning to better understand outcomes in all areas of cancer treatment and ensure that your members receive the right treatment at the right time and the right cost. Our comprehensive approach to real-world data and analytics is based on the organization and normalization of clinical data, such as EMR progress notes, pathology and lab reports, biomarker data, histology, and cancer stage. Clinical data is then combined with claims data to provide unique insights and benchmarks focused on health plans’ oncology spend, trend, and provider network performance.";
            Dictionary<string, int> results = Helper.CountWords(input);
            Assert.IsTrue(true);
        }

        //we could write a whole lot more tests.,....
    }
}