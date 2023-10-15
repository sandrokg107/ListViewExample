using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;
using static System.Collections.Specialized.BitVector32;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        //Coleccion de sections para listar
        ObservableCollection<Section> sections = new ObservableCollection<Section>();
        public ObservableCollection<Section> Sections { get { return sections; } }
        public ListViewGroup()
        {
            InitializeComponent();
            //Inicializando datos
            var sectionA = new Section()
            {
                LongName = "Seccion A",
                ShortName = "A",
            };

            var sectionB = new Section()
            {
                LongName = "Seccion B",
                ShortName = "B",
            };

            var sectionC = new Section()
            {
                LongName = "Seccion C",
                ShortName = "C",
            };

            var sectionD = new Section()
            {
                LongName = "Seccion D",
                ShortName = "D",
            };

            sectionA.Add(new Student() { Name = "Sandro", LastName = "Dominguez", Age = 20 });
            sectionA.Add(new Student() { Name = "Cesar", LastName = "Ramirez", Age = 21 });

            sectionB.Add(new Student() { Name = "Marcelo", LastName = "Miranda", Age = 22 });
            sectionB.Add(new Student() { Name = "Enrique", LastName = "Mamani", Age = 20 });

            sectionC.Add(new Student() { Name = "Rosa", LastName = "Marquez", Age = 18 });
            sectionC.Add(new Student() { Name = "Raul", LastName = "Albornoz", Age = 16 });

            sectionD.Add(new Student() { Name = "Jessenia", LastName = "Laporte", Age = 18 });
            sectionD.Add(new Student() { Name = "Carla", LastName = "Mendoza", Age = 25 });

            sections.Add(sectionA);
            sections.Add(sectionB);
            sections.Add(sectionC);
            sections.Add(sectionD);

            sectionView.ItemsSource = sections;
        }
    }
}