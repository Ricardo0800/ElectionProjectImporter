
using System.Text.Json.Serialization;

public class CandidatesFile
{
    [JsonPropertyName("candidatos")]
    public List<CandidateData> Candidates { get; set; } = [];
}

public class CandidateData
{
    [JsonPropertyName("nome")]
    public string Name { get; set; } = "";

    [JsonPropertyName("cargo")]
    public string Cargo { get; set; } = "";

    [JsonPropertyName("categorias")]
    public List<CategoryData> Categories { get; set; } = [];
}

public class CategoryData
{
    [JsonPropertyName("nome")]
    public string Name { get; set; } = "";

    [JsonPropertyName("temas")]
    public List<TopicData> Topics { get; set; } = [];
}

public class TopicData
{
    [JsonPropertyName("nome")]
    public string Name { get; set; } = "";
}
