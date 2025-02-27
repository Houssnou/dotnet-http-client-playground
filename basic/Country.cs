﻿using System.Text.Json.Serialization;

namespace basic;

public class Country
{
    [JsonPropertyName("name")]
    public Name Name { get; set; }
}

public class Name
{
    [JsonPropertyName("common")]
    public string Common { get; set; }

    [JsonPropertyName("official")]
    public string Official { get; set; }

}


