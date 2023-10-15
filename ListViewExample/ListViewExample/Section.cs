using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Xamarin.Forms;

namespace ListViewExample
{
    public class Section : ObservableCollection<Student>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}