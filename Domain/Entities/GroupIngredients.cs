namespace MealCraft.Domain.Entites
{
    public class GroupIngredients : BaseEntity
    {
        public Guid RecipeId { get; set; }

        public Recipe Recipe { get; set; } = null!;

        public string Title { get; set; } = string.Empty;

        public List<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    }
}
