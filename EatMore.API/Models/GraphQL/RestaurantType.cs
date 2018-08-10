using GraphQL.Types;

namespace EatMore.API.Models.GraphQL
{
    public class RestaurantType : ObjectGraphType<Restaurant>
    {
        public RestaurantType()
        {
            Name = "Restaurant";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Restaurant.");
            Field(x => x.Name).Description("The name of the Restaraunt");
            Field(x => x.Menus, type: typeof(MenuType)).Description("Restaurant Menus");
        }
    }
}
