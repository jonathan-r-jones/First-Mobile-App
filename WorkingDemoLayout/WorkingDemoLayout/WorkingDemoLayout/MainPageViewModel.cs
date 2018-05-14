using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingDemoLayout
{
    class MainPageViewModel
    {
        public string Prompt { get; set; }
        public string Name { get; set; }
        public MainPageViewModel()
        {
            Prompt = "Full Name: ";
            Name = "Jesse Liberty";
        }
    }
}
