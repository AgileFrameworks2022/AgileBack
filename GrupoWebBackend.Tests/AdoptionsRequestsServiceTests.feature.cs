﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GrupoWebBackend.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AdoptionsRequestsServiceTests")]
    public partial class AdoptionsRequestsServiceTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "AdoptionsRequestsServiceTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "AdoptionsRequestsServiceTests", "As a Developer\r\nI want to add new Adoption Requests through API\r\nSo that it is av" +
                    "ailable when the user make a adoption requests", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
 #line hidden
#line 6
  testRunner.Given("The Endpoint https://localhost:5001/api/v1/AdoptionsRequests is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Type",
                        "UserNick",
                        "Ruc",
                        "Dni",
                        "Phone",
                        "Email",
                        "Name",
                        "LastName",
                        "DistrictId"});
            table4.AddRow(new string[] {
                        "1",
                        "VET",
                        "Frank",
                        "A12345rf",
                        "70258688",
                        "946401234",
                        "frank@outlook.com",
                        "Francisco",
                        "Voularte",
                        "1"});
#line 7
  testRunner.And("A User is already stored for AdoptionsRequests", ((string)(null)), table4, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A AdoptionsRequests is sent")]
        [NUnit.Framework.CategoryAttribute("adoptionsrequests-adding")]
        public void AAdoptionsRequestsIsSent()
        {
            string[] tagsOfScenario = new string[] {
                    "adoptionsrequests-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A AdoptionsRequests is sent", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "message",
                            "status",
                            "userIdFrom",
                            "userIdAt",
                            "publicationId"});
                table5.AddRow(new string[] {
                            "hello",
                            "pending",
                            "3",
                            "1",
                            "1"});
#line 12
  testRunner.When("A adoption request is sent", ((string)(null)), table5, "When ");
#line hidden
#line 15
  testRunner.Then("A Response with Status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Adoption Request with empty data")]
        public void AddAdoptionRequestWithEmptyData()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Adoption Request with empty data", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status"});
                table6.AddRow(new string[] {
                            "hello",
                            ""});
#line 17
  testRunner.When("A post adoption request is sent", ((string)(null)), table6, "When ");
#line hidden
#line 20
  testRunner.Then("AAdoptionRequests With Status 400 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Adoption Request with same data")]
        public void AddAdoptionRequestWithSameData()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Adoption Request with same data", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status",
                            "UserIdFrom",
                            "UserId",
                            "PublicationId"});
                table7.AddRow(new string[] {
                            "hello",
                            "pending",
                            "2",
                            "1",
                            "1"});
#line 22
  testRunner.When("A post adoption request is sent", ((string)(null)), table7, "When ");
#line hidden
#line 25
  testRunner.Then("AAdoptionRequests With Status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete a adoptions request dont available")]
        public void DeleteAAdoptionsRequestDontAvailable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete a adoptions request dont available", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status",
                            "UserIdFrom",
                            "UserId",
                            "PublicationId"});
                table8.AddRow(new string[] {
                            "hello",
                            "pending",
                            "2",
                            "2",
                            "18"});
#line 28
  testRunner.When("An a delete request of adoptions requests is sent", ((string)(null)), table8, "When ");
#line hidden
#line 31
  testRunner.Then("a response with status 400 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Database update its information when there is a new candidate for adopting")]
        public void DatabaseUpdateItsInformationWhenThereIsANewCandidateForAdopting()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Database update its information when there is a new candidate for adopting", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
#line 34
  testRunner.Given("the endpoint https://localhost:5001/api/v1/AdoptionsRequests/1 is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Type",
                            "UserNick",
                            "Pass",
                            "Ruc",
                            "Dni",
                            "Phone",
                            "Email",
                            "Name",
                            "LastName",
                            "DistrictId"});
                table9.AddRow(new string[] {
                            "2",
                            "client",
                            "an",
                            "Password",
                            "A12345rf",
                            "70258688",
                            "946401234",
                            "ana@gmail.com",
                            "Ana",
                            "Araoz",
                            "1"});
#line 35
  testRunner.And("A User is already stored for AdoptionsRequests", ((string)(null)), table9, "And ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status",
                            "UserIdFrom",
                            "UserId",
                            "PublicationId"});
                table10.AddRow(new string[] {
                            "hello",
                            "pending",
                            "2",
                            "1",
                            "1"});
#line 38
  testRunner.When("An update  adoption request is sent", ((string)(null)), table10, "When ");
#line hidden
#line 41
  testRunner.Then("a response with status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
