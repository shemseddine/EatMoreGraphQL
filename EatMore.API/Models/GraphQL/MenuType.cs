using GraphQL.Types;

namespace EatMore.API.Models.GraphQL
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Name = "Menu";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the menu.");
            Field(x => x.Name).Description("The name of the menu");
            Field(x => x.MenuItems, type: typeof(MenuItemType)).Description("The menu items.");
        }
    }
}
