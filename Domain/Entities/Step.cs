namespace MealCraft.Domain.Entites
{
    public class Step : BaseEntity
    {
        public Guid RecipeId { get; set; }

        public Recipe Recipe { get; set; } = null!;

        public int Number { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
