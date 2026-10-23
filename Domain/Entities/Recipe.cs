namespace MealCraft.Domain.Entites
{
    public class Recipe : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public int CookingTime { get; set; }

        public string Description { get; set; } = string.Empty;

        public List<GroupIngredients> GroupIngredients { get; set; } = new List<GroupIngredients>();

        public List<Step> Steps { get; set; } = new List<Step>();

        public List<string> Tags { get; set; } = new List<string>();
    }
}
