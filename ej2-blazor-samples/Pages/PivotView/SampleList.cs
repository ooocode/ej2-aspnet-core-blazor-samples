﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "User Interaction",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/UserInteraction",
                FileName = "UserInteraction.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Label and Value Filtering",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/AdvanceFiltering",
                FileName = "AdvanceFiltering.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Chart",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/Chart",
                FileName = "Chart.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Editing",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/Editing",
                FileName = "Editing.razor",
                Type = SampleType.New
            }
        };
    }
}