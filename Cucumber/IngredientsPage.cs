using OpenQA.Selenium;

namespace Cucumber
{
    public class IngredientsPage
    {
        private readonly IWebDriver _driver;

        private readonly string _ingredientsTabId = "ingredients-fa1155";
        private readonly string _ingredientsListId = "ingredients-list-fa1155";
        private readonly string _ingredientsListItemId = "XPath route to the <li> element.";
        private readonly string _ingredientsDetailsCardId = "ingredients-details-card-fs1155";

        public IngredientsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Enabled => _driver.FindElement(By.Id(_ingredientsTabId));

        public IWebElement Displayed => _driver.FindElement(By.Id(_ingredientsTabId));

        public IWebElement IngredientsTab => _driver.FindElement(By.Id(_ingredientsTabId));

        public IWebElement IngredientsList => _driver.FindElement(By.Id(_ingredientsListId));

        public IWebElement IngredientsListItem => _driver.FindElement(By.Id(_ingredientsListItemId));
        
        public IWebElement IngredientsDetailsCard => _driver.FindElement(By.Id(_ingredientsDetailsCardId));
    }
}
