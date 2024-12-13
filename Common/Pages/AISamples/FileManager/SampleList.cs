#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> AIFileManager { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Smart FileManager",
                Category = "File Manager",
                Directory = "AISamples/FileManager",
                Url = "ai-filemanager/smart-filemanager",
                FileName = "SmartFileManager.razor",
                NotificationDescription = new string[]{ @" This demo shows the smart AI feature in file manager component." }
            }
        };
    }
}