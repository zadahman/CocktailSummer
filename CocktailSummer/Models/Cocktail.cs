using System.Text.Json.Serialization;

namespace CocktailSummer.Models
{
    public class Cocktail
    {
        [JsonPropertyName("idDrink")]
        public string Id { get; set; }

        [JsonPropertyName("strDrink")]
		public string Name { get; set; }

		[JsonPropertyName("strAlcoholic")]
        public string DrinkType { get; set; }

		[JsonPropertyName("strGlass")]
		public string GlassType { get; set; }

		[JsonPropertyName("strCategory")]
		public string DrinkCategory { get; set; }

		[JsonPropertyName("strInstructions")]
        public string Instructions { get; set; }

		[JsonPropertyName("strDrinkThumb")]
		public string ImageLink { get; set; }

		[JsonPropertyName("strIngredient1")]
		public string Ingredient1 { get; set; }

		[JsonPropertyName("strIngredient2")]
		public string Ingredient2 { get; set; }

		[JsonPropertyName("strIngredient3")]
		public string Ingredient3 { get; set; }

		[JsonPropertyName("strIngredient4")]
		public string Ingredient4 { get; set; }

		[JsonPropertyName("strIngredient5")]
		public string Ingredient5 { get; set; }

		[JsonPropertyName("strIngredient6")]
		public string Ingredient6 { get; set; }

		[JsonPropertyName("strIngredient7")]
		public string Ingredient7 { get; set; }

		[JsonPropertyName("strIngredient8")]
		public string Ingredient8 { get; set; }

		[JsonPropertyName("strIngredient9")]
		public string Ingredient9 { get; set; }

		[JsonPropertyName("strIngredient10")]
		public string Ingredient10 { get; set; }

		[JsonPropertyName("strIngredient11")]
		public string Ingredient11 { get; set; }

		[JsonPropertyName("strIngredient12")]
		public string Ingredient12 { get; set; }

		[JsonPropertyName("strIngredient13")]
		public string Ingredient13 { get; set; }

		[JsonPropertyName("strIngredient14")]
		public string Ingredient14 { get; set; }

		[JsonPropertyName("strIngredient15")]
		public string Ingredient15 { get; set; }

		[JsonPropertyName("strMeasure1")]
		public string MeasureForIngredient1 { get; set; }

		[JsonPropertyName("strMeasure2")]
		public string MeasureForIngredient2 { get; set; }

		[JsonPropertyName("strMeasure3")]
		public string MeasureForIngredient3 { get; set; }

		[JsonPropertyName("strMeasure4")]
		public string MeasureForIngredient4 { get; set; }

		[JsonPropertyName("strMeasure5")]
		public string MeasureForIngredient5 { get; set; }

		[JsonPropertyName("strMeasure6")]
		public string MeasureForIngredient6 { get; set; }

		[JsonPropertyName("strMeasure7")]
		public string MeasureForIngredient7 { get; set; }

		[JsonPropertyName("strMeasure8")]
		public string MeasureForIngredient8 { get; set; }

		[JsonPropertyName("strMeasure9")]
		public string MeasureForIngredient9 { get; set; }

		[JsonPropertyName("strMeasure10")]
		public string MeasureForIngredient10 { get; set; }

		[JsonPropertyName("strMeasure11")]
		public string MeasureForIngredient11 { get; set; }

		[JsonPropertyName("strMeasure12")]
		public string MeasureForIngredient12 { get; set; }

		[JsonPropertyName("strMeasure13")]
		public string MeasureForIngredient13 { get; set; }

		[JsonPropertyName("strMeasure14")]
		public string MeasureForIngredient14 { get; set; }

		[JsonPropertyName("strMeasure15")]
		public string MeasureForIngredient15 { get; set; }

        public string Comment { get; set; }
	}
}