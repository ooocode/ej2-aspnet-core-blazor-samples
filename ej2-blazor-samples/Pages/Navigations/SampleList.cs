﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Sidebar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },                      
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/Dock",
                FileName = "Dock.razor",
                Type = SampleType.New
            },          
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/SidebarWithListView",
                FileName = "SidebarWithListView.razor",
                Type = SampleType.New
            },         
            new Sample
            {
                Name = "Sidebar Menu",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/SidebarWithMenu",
                FileName = "SidebarWithMenu.razor",
                Type = SampleType.New
            },           
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/PanelWithResponsive",
                FileName = "PanelWithResponsive.razor",
                Type = SampleType.New
            }           
        };

        public List<Sample> ContextMenu { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ContextMenu",
                Directory = "Navigations/ContextMenu",
                FileName = "DefaultFunctionalities.razor",
                Url = "ContextMenu/DefaultFunctionalities"
            }
        };
        public List<Sample> MenuBar { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DefaultFunctionalities.razor",
                Url = "MenuBar/DefaultFunctionalities"
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DataBinding.razor",
                Url = "MenuBar/DataBinding"
            }
        };

        public List<Sample> Accordion { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "DefaultFunctionalities.razor",
                 Url = "Accordion/DefaultFunctionalities",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Icons",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "Icons.razor",
                 Url = "Accordion/Icons",
                Type = SampleType.New
            }
        };
		
		public List<Sample> Toolbar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                Url = "Toolbar/DefaultFunctionalities"
            },
            new Sample
            {
                Name = "Popup",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Popup.razor",
                Type = SampleType.New,
                Url = "Toolbar/Popup"
            }
        };

        public List<Sample> Tab { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tab",
                Directory = "Navigations/Tab",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                 Url = "Tab/DefaultFunctionalities"
            }
        };
        public List<Sample> TreeView { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "CheckBox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/CheckBox",
                FileName = "CheckBox.razor",
                Type = SampleType.New
            }
        };
         public List<Sample> FileManager { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "FileManager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/Overview",
                FileName = "Overview.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "CustomThumbnail",
                Category = "FileManager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/CustomThumbnail",
                FileName = "CustomThumbnail.razor",
                Type = SampleType.New
            }
        };
    }
}
