﻿using System.Text.Json.Serialization;

namespace LCARS.BitBucket.Models;

public record PullRequests
{
    public IEnumerable<PullRequestModel>? Values { get; set; }

    public record PullRequestModel
    {
        [JsonPropertyName("id")]
        public int Number { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? State { get; set; }
        [JsonPropertyName("created_on")]
        public string? CreatedOn { get; set; }
        [JsonPropertyName("updated_on")]
        public string? UpdatedOn { get; set; }
        [JsonPropertyName("author")]
        public AuthorModel User { get; set; } = new AuthorModel();
        [JsonPropertyName("comment_count")]
        public int CommentCount { get; set; }

        public record AuthorModel
        {
            [JsonPropertyName("display_name")]
            public string? Name { get; set; }
        }
    }
}