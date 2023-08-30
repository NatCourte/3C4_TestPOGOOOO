using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace cours4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Group SelectedGroup { get => (Group)ComboBoxGroups.SelectedItem; }

        public MainWindow()
        {
            InitializeComponent();

            object doctor = new Doctor();
            //doctor.Name = "Mael";

            Doctor d1 = (Doctor)doctor;
            if (d1 != null)
            {
                d1.Name = "Mael";
            }

            ((Doctor)doctor).Name = "Mael";

            object obj = (object)d1;

            //List<object> doctors = new List<object>();

            Doctor d2 = obj as Doctor;

            if (obj is Doctor)
            {

            }

            int number = 10;

            int? number2 = 10;

            string name = "allo";

            string? name2 = "bonjour!";

            if (name2 != null)
            {

            }



            CheckBoxPogo.IsChecked = true;


            List<Group> groups = new List<Group>()
            {
                new Group() { Name = "Group 1", Time = 10 },
                new Group() { Name = "Group 1", Time = 12 },
                new Group() { Name = "Group 1", Time = 15 }
            };

            foreach (Group group in groups)
            {
                ComboBoxGroups.Items.Add(group);
            }

            ComboBoxGroups.SelectedItem = groups[0];

            ComboBoxGroups.SelectionChanged += ComboBoxGroups_SelectionChanged;
        }

        private void ComboBoxGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = (Group)ComboBoxGroups.SelectedItem;
            Group group = (Group)selectedItem;
            if (group != null)
            {
                group.Time = 10;
            }
        }

        private class Doctor
        {
            public string Name { get; set; }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            bool? isChecked = checkBox.IsChecked;

            if (isChecked == true)
            {

            }
        }

        private void RadioButtonDrink_Checked(object sender, RoutedEventArgs e)
        {
            if (SelectedGroup != null)
                return;

            if (RadioButtonCoke.IsChecked == true)
            {
                SelectedGroup.Drink = Group.DrinkType.Coke;
            }
            else if (RadioButton7up.IsChecked == true)
            {
                SelectedGroup.Drink = Group.DrinkType.SevenUp;
            }
            else
            {
                SelectedGroup.Drink = Group.DrinkType.CanadaDry;
            }
        }

        private class Group
        {
            public enum DrinkType
            {
                Coke,
                SevenUp,
                CanadaDry
            };

            public string Name { get; set; }
            public int Time { get; set; }
            public DrinkType Drink { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Time}h";
            }
        }
    }
}

