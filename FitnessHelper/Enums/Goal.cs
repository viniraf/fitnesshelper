﻿using System.ComponentModel;
using System.Text.Json.Serialization;

namespace FitnessHelper.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Goal
    {
        GainWeight = 0,
        LoseWeight = 1,
        MaintainWeight = 2,
    }
}
