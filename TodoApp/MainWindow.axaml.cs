using Avalonia.Controls;
using System.Collections.ObjectModel;

namespace TodoApp
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> tasks = new();

        public MainWindow()
        {
            InitializeComponent();

            // Vincular la lista al ListBox
            TaskList.ItemsSource = tasks;

            AddButton.Click += AddButton_Click;
            RemoveButton.Click += RemoveButton_Click;
        }

        private void AddButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskInput.Text))
            {
                tasks.Add(TaskInput.Text);
                TaskInput.Text = string.Empty;
            }
        }

        private void RemoveButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (TaskList.SelectedItem is string selected)
            {
                tasks.Remove(selected);
            }
        }
    }
}