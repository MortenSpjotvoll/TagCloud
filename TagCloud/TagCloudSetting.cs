using LemmaSharp;
using System.Text.RegularExpressions;

namespace TagCloud;

/// <summary>
/// Represents the settings for a TagCloudAnalyzer instance.
/// </summary>
public class TagCloudSetting
{
    private static Regex defaultWordFinder = new Regex(@"[\w\']+", RegexOptions.Compiled);
    private static LemmatizerPrebuilt defaultLemmatizer = new LemmatizerPrebuiltFull(LanguagePrebuilt.English);

    /// <summary>
    /// Initializes a new instance of the TagCloudSetting class. 
    /// </summary>
    public TagCloudSetting()
    {
        this.WordFinder = defaultWordFinder;
        this.Lemmatizer = defaultLemmatizer;
        this.MaxCloudSize = 100;
        this.NumCategories = 10;
    }

    /// <summary>
    /// Gets or sets the regex used to find words within strings.
    /// </summary>
    public Regex WordFinder { get; set; }

    /// <summary>
    /// Gets or sets the lemmatizer used to derive the roots of words.
    /// </summary>
    public LemmatizerPrebuilt Lemmatizer { get; set; }

    /// <summary>
    /// Gets or sets the maximum size of the tag cloud.
    /// </summary>
    public int MaxCloudSize { get; set; }

    /// <summary>
    /// Gets or sets the number of tag categories.
    /// </summary>
    public int NumCategories { get; set; }
}