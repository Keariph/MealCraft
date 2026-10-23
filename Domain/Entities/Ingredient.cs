using MealCraft.Domain.Enums;

namespace MealCraft.Domain.Entites
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}
