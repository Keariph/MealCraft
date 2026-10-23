namespace MealCraft.Domain.Entites
{
    public class RecipeIngredient : BaseEntity
    {
        public Guid GroupIngredientsId { get; set; }

        public GroupIngredients GroupIngredients { get; set; } = null!;

        public Guid IngredientId { get; set; }

        public Ingredient Ingredient { get; set; } = null!;

        public decimal IngredientAmount { get; set; }
    }
}
