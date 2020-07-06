using System;
using System.Collections.Generic;

public class Recipe
{
	public string Name { get; internal set; }
	public string Category { get; internal set; }
	public string Area { get; internal set; }
	public string Tags { get; internal set; }
	public List<KeyValuePair<string, string>> Ingredients { get; internal set; }
	public string Instructions { get; internal set; }
	public string Thumbnail { get; internal set; }
	public string YoutubeLink { get; internal set; }

	public Recipe()
    {

    }

	public Recipe(string aName, string aCategory, string aArea, string aTags,
		List<KeyValuePair<string, string>> aIngredients, string aInstructions, string aThumbnail, string aYoutubeLink)
	{
		Name = aName;
		Category = aCategory;
		Area = aArea;
		Tags = aTags;
		Ingredients = aIngredients;
		Instructions = aInstructions;
		Thumbnail = aThumbnail;
		YoutubeLink = aYoutubeLink;
	}
}
