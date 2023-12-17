using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TaskApp.Views
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public List<TaskAppCase4.Entites.Task> databaseTask { get; private set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        public void Create()
        {
            using (TaskAppCase4.Entites.DataContext context = new TaskAppCase4.Entites.DataContext())
            {
                var title = TitleTextBox.Text;
                var description = DescriptionTextBox.Text;


                if (title != null && description != null)
                {
                    context.Tasks.Add(new TaskAppCase4.Entites.Task() { Title = title, Description = description });
                    context.SaveChanges();
                }

            }
        }

        public void Read()
        {
            using (TaskAppCase4.Entites.DataContext context = new TaskAppCase4.Entites.DataContext())
            {
                //return a task list
                databaseTask = context.Tasks.ToList();
                TaskList.ItemsSource = databaseTask;

            }
        }

        public void Update()
        {
            using (TaskAppCase4.Entites.DataContext context = new TaskAppCase4.Entites.DataContext())
            {
                TaskAppCase4.Entites.Task selectedTask = TaskList.SelectedItem as TaskAppCase4.Entites.Task;

                var title = TitleTextBox.Text;
                var description = DescriptionTextBox.Text;

                if (title != null && description != null)
                {
                    TaskAppCase4.Entites.Task task = context.Tasks.Find(selectedTask.TaskId);

                    task.Title = title;
                    task.Description = description;

                    context.SaveChanges();
                }
            }
        }

        public void Delete()
        {
            using (TaskAppCase4.Entites.DataContext context = new TaskAppCase4.Entites.DataContext())
            {
                TaskAppCase4.Entites.Task selectedTask = TaskList.SelectedItem as TaskAppCase4.Entites.Task;

                if (selectedTask != null)
                {
                    TaskAppCase4.Entites.Task task = context.Tasks.Single(x => x.TaskId == selectedTask.TaskId);

                    context.Remove(task);
                    context.SaveChanges();
                }

            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            Read();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            TaskList.Items.Clear();
        }
    }
}