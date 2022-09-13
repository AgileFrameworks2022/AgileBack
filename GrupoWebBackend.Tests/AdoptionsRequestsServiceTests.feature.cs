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
    public partial class AdoptionsRequestsServiceTestsFeature : object, Xunit.IClassFixture<AdoptionsRequestsServiceTestsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AdoptionsRequestsServiceTests.feature"
#line hidden
        
        public AdoptionsRequestsServiceTestsFeature(AdoptionsRequestsServiceTestsFeature.FixtureData fixtureData, GrupoWebBackend_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "AdoptionsRequestsServiceTests", "As a Developer\r\nI want to add new Adoption Requests through API\r\nSo that it is av" +
                    "ailable when the user make a adoption requests", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
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
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="A AdoptionsRequests is sent")]
        [Xunit.TraitAttribute("FeatureTitle", "AdoptionsRequestsServiceTests")]
        [Xunit.TraitAttribute("Description", "A AdoptionsRequests is sent")]
        [Xunit.TraitAttribute("Category", "adoptionsrequests-adding")]
        public virtual void AAdoptionsRequestsIsSent()
        {
            string[] tagsOfScenario = new string[] {
                    "adoptionsrequests-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A AdoptionsRequests is sent", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Adoption Request with empty data")]
        [Xunit.TraitAttribute("FeatureTitle", "AdoptionsRequestsServiceTests")]
        [Xunit.TraitAttribute("Description", "Add Adoption Request with empty data")]
        public virtual void AddAdoptionRequestWithEmptyData()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Adoption Request with empty data", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 16
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Adoption Request with same data")]
        [Xunit.TraitAttribute("FeatureTitle", "AdoptionsRequestsServiceTests")]
        [Xunit.TraitAttribute("Description", "Add Adoption Request with same data")]
        public virtual void AddAdoptionRequestWithSameData()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Adoption Request with same data", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Delete a adoptions request dont available")]
        [Xunit.TraitAttribute("FeatureTitle", "AdoptionsRequestsServiceTests")]
        [Xunit.TraitAttribute("Description", "Delete a adoptions request dont available")]
        public virtual void DeleteAAdoptionsRequestDontAvailable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete a adoptions request dont available", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Database update its information when there is a new candidate for adopting")]
        [Xunit.TraitAttribute("FeatureTitle", "AdoptionsRequestsServiceTests")]
        [Xunit.TraitAttribute("Description", "Database update its information when there is a new candidate for adopting")]
        public virtual void DatabaseUpdateItsInformationWhenThereIsANewCandidateForAdopting()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Database update its information when there is a new candidate for adopting", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 33
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
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
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AdoptionsRequestsServiceTestsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AdoptionsRequestsServiceTestsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
