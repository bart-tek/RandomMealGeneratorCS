using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

public static class ApiCaller
{
    static readonly HttpClient vClient = new HttpClient();

    public static void Run()
    {
        // Update port # in the following line.
        vClient.BaseAddress = new Uri("https://www.themealdb.com/api/json/v1/1/");
        vClient.DefaultRequestHeaders.Accept.Clear();
        vClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public static async Task<Recipe> GetRandomMealAsync()
    {
        string vJson = null;
        Recipe vRecipe = new Recipe();

        HttpResponseMessage vResponse = await vClient.GetAsync("random.php");

        if (vResponse.IsSuccessStatusCode)
        {
            vJson = await vResponse.Content.ReadAsStringAsync();
            var vJsonObject = new JavaScriptSerializer().Deserialize<Dictionary<string, List<Dictionary<string, string>>>>(vJson);
            var vJsonMeal = vJsonObject["meals"][0];

            vRecipe.Name = vJsonMeal["strMeal"];
            vRecipe.Category = vJsonMeal["strCategory"];
            vRecipe.Area = vJsonMeal["strArea"];
            vRecipe.Instructions = vJsonMeal["strInstructions"];
            vRecipe.Thumbnail = vJsonMeal["strMealThumb"];
            vRecipe.Tags = vJsonMeal["strTags"];
            vRecipe.YoutubeLink = vJsonMeal["strYoutube"];
            vRecipe.Ingredients = new List<KeyValuePair<string, string>>();

            for (int i = 1; i <= 20; i++)
            {
                string vIngredient = "strIngredient" + i;
                string vMeasure = "strMeasure" + i;
                KeyValuePair<string, string> vIngMeasurePair = new KeyValuePair<string, string>(vJsonMeal[vIngredient], vJsonMeal[vMeasure]);
                if (vIngMeasurePair.Key != null && vIngMeasurePair.Key != "")
                {
                    vRecipe.Ingredients.Add(vIngMeasurePair);
                }
            }
        }

        return vRecipe;
    }
}