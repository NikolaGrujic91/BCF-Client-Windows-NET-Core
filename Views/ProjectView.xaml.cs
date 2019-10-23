using System;
using System.Windows;
using System.Windows.Controls;
using BIMcollab_BCF_WPF_MVVM.Model;
using BIMcollab_BCF_WPF_MVVM.ViewModel;

namespace BIMcollab_BCF_WPF_MVVM.Views
{
    /// <summary>
    /// Interaction logic for ProjectView.xaml
    /// </summary>
    public partial class ProjectView : UserControl
    {
        #region Fields

        private readonly ProjectViewModel projectViewModelObject;

        #endregion

        #region Constructors

        public ProjectView()
        {
            this.InitializeComponent();

            this.projectViewModelObject = new ProjectViewModel();
            this.DataContext = this.projectViewModelObject;
        }

        #endregion

        #region Delegates

        internal class ConnectedEventArgs : EventArgs
        {
            public ConnectedEventArgs(Project project)
            {
                this.ActiveProject = project;
            }

            public Project ActiveProject { get; }
        }

        internal delegate void OnConnectedDelegate(ConnectedEventArgs args);

        internal event OnConnectedDelegate Connected;

        #endregion

        #region Events

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool connected = this.projectViewModelObject.ConnectToProject(this.UsernameTextBox.Text, this.PasswordBox.Password);

            if (connected)
            {
                this.UsernameTextBox.Text = string.Empty;
                this.PasswordBox.Password = string.Empty;
                this.InfoLabel.Content = $"Active project: {this.projectViewModelObject.ActiveProjectTitle}";
                this.ApiVersionLabel.Content = $"API: {this.projectViewModelObject.ApiVersion}";
                this.WebServiceVersionLabel.Content = $"WebService: {this.projectViewModelObject.WebServiceVersion}";
                this.DatabaseVersionLabel.Content = $"Database: {this.projectViewModelObject.DatabaseVersion}";

                this.Connected?.Invoke(new ConnectedEventArgs(this.projectViewModelObject.ActiveProject));
            }
        }

        #endregion
    }
}
