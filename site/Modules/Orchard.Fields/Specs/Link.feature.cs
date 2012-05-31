﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Fields.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Link Field")]
    public partial class LinkFieldFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Link.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Link Field", "  In order to add Link content to my types\r\nAs an administrator\r\n  I want to crea" +
                    "te, edit and publish Link fields", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating and using Link fields")]
        public virtual void CreatingAndUsingLinkFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating and using Link fields", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I have installed Orchard");
#line 10
  testRunner.And("I have installed \"Orchard.Fields\"");
#line 11
    testRunner.When("I go to \"Admin/ContentTypes\"");
#line 12
    testRunner.Then("I should see \"<a[^>]*>.*?Create new type</a>\"");
#line 13
    testRunner.When("I go to \"Admin/ContentTypes/Create\"");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "DisplayName",
                        "Event"});
            table1.AddRow(new string[] {
                        "Name",
                        "Event"});
#line 14
        testRunner.And("I fill in", ((string)(null)), table1);
#line 18
        testRunner.And("I hit \"Create\"");
#line 19
        testRunner.And("I go to \"Admin/ContentTypes/\"");
#line 20
    testRunner.Then("I should see \"Event\"");
#line 23
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line 24
  testRunner.And("I follow \"Add Field\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "DisplayName",
                        "Site Url"});
            table2.AddRow(new string[] {
                        "Name",
                        "SiteUrl"});
            table2.AddRow(new string[] {
                        "FieldTypeName",
                        "LinkField"});
#line 25
  testRunner.And("I fill in", ((string)(null)), table2);
#line 30
  testRunner.And("I hit \"Save\"");
#line 31
  testRunner.And("I am redirected");
#line 32
 testRunner.Then("I should see \"The \\\"Site Url\\\" field has been added.\"");
#line 35
 testRunner.When("I go to \"Admin/Contents/Create/Event\"");
#line 36
 testRunner.Then("I should see \"Site Url\"");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Event.SiteUrl.Value",
                        "http://www.orchardproject.net"});
#line 37
 testRunner.When("I fill in", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Event.SiteUrl.Text",
                        "Orchard"});
#line 40
  testRunner.And("I fill in", ((string)(null)), table4);
#line 43
  testRunner.And("I hit \"Save\"");
#line 44
  testRunner.And("I am redirected");
#line 45
 testRunner.Then("I should see \"Your Event has been created.\"");
#line 46
 testRunner.When("I go to \"Admin/Contents/List\"");
#line 47
 testRunner.Then("I should see \"Site Url:\"");
#line 48
  testRunner.And("I should see \"<a href=\\\"http://www.orchardproject.net\\\">Orchard</a>\"");
#line 51
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Hint",
                        "Enter the url of the web site"});
#line 52
  testRunner.And("I fill in", ((string)(null)), table5);
#line 55
  testRunner.And("I hit \"Save\"");
#line 56
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line 57
 testRunner.Then("I should see \"Enter the url of the web site\"");
#line 60
 testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Required",
                        "true"});
#line 61
  testRunner.And("I fill in", ((string)(null)), table6);
#line 64
  testRunner.And("I hit \"Save\"");
#line 65
  testRunner.And("I go to \"Admin/Contents/Create/Event\"");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Event.SiteUrl.Value",
                        ""});
#line 66
  testRunner.And("I fill in", ((string)(null)), table7);
#line 69
  testRunner.And("I hit \"Save\"");
#line 70
 testRunner.Then("I should see \"Url is required for Site Url.\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
