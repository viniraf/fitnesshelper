﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FitnessHelper.Models;

public class TrainingHistoryModel
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int TrainingId { get; set; }

    [NotMapped]
    public string TrainingName { get; set; } = string.Empty;

    [JsonIgnore]
    public int UserId { get; set; }

    [JsonIgnore]
    public TrainingModel Training { get; set; }
}
