using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Cucumber
{
    [Binding]
    public class CucumberSteps
    {
        private readonly IngredientsPage _ingredientsPage;

        public CucumberSteps()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _ingredientsPage = new IngredientsPage(driver);
        }

        [Given(@"the user can see the ingredients tab")]
        public void GivenTheUserCanSeeTheIngredientsTab()
        {
            var ingredientsTab = _ingredientsPage.IngredientsTab;
            Assert.IsTrue(ingredientsTab.Displayed);
            Assert.IsTrue(ingredientsTab.Enabled);
        }
        
        [Given(@"the user clicks on the ingredients tab")]
        public void GivenTheUserClicksOnTheIngredientsTab()
        {
            _ingredientsPage.IngredientsTab.Click();
        }
        
        [Then(@"the user can see the ingredients list")]
        public void ThenTheUserCanSeeTheIngredientsList()
        {
            Assert.IsTrue(_ingredientsPage.IngredientsList.Displayed);
        }

        [Then(@"the user can see '(.*)' in the ingredients list items")]
        public void ThenTheUserCanSeeInTheIngredientsListItems(string ingredient)
        {
            Assert.IsTrue(_ingredientsPage.IngredientsListItem.Displayed);
        }

        [Then(@"the user clicks on the '(.*)' item from the ingredients list")]
        public void ThenTheUserClicksOnTheItemFromTheIngredientsList(string ingredient)
        {
            _ingredientsPage.IngredientsListItem.Click();
        }

        [Then(@"the user can see '(.*)' in the ingredients detail card")]
        public void ThenTheUserCanSeeInTheIngredientsDetailCard(string ingredient)
        {
            Assert.IsTrue(_ingredientsPage.IngredientsDetailsCard.Displayed);
            Assert.IsTrue(_ingredientsPage.IngredientsDetailsCard.Enabled);
        }
    }
}
