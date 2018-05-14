using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViews.ViewModel
{
    class MainPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public MainPageViewModel()
        {
            for (int i = 0; i < 5; i++)
            {
                Person person = new Person();
                person.Name = "Jesse Liberty " + i.ToString();
                person.Address = i.ToString() + " Main Street";
                People.Add(person);
            }
        }
    }
}
