﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestFull.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime PublishDate { get; set; }

    public int AuthorId { get; set; }

    public int CategoryId { get; set; }
    [JsonIgnore]
    public virtual Author Author { get; set; } = null!;
    [JsonIgnore]
    public virtual Category Category { get; set; } = null!;
}
