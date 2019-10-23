using System;
using BIMcollab_BCF_WPF_MVVM.Model;
using BIMcollab_BCF_WPF_MVVM.Utility;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal class ProjectViewModel
    {
        #region Constructors

        public ProjectViewModel()
        {

        }

        #endregion

        #region Properties

        public Project ActiveProject { get; private set; }

        public string ActiveProjectTitle
        {
            get { return this.ActiveProject.Title; }
        }

        public string ApiVersion
        {
            get { return this.ActiveProject.ApiVersion; }
        }

        public string WebServiceVersion
        {
            get { return this.ActiveProject.WebServiceVersion; }
        }

        public string DatabaseVersion
        {
            get { return this.ActiveProject.DatabaseVersion; }
        }

        #endregion

        #region Methods

        public bool ConnectToProject(string username, string password)
        {
            if (this.IsAlreadyConnected())
            {
                return false;
            }

            if (username == string.Empty || password == string.Empty)
            {
                return false;
            }

            return this.CreateActiveProject(username, password);
        }

        private bool IsAlreadyConnected()
        {
            return this.ActiveProject != null;
        }

        private bool CreateActiveProject(string username, string password)
        {
            try
            {
                this.TryCreateActiveProject(username, password);
                return true;
            }
            catch (Exception e)
            {
                LogWriter.LogWrite($"{e.Message}{Environment.NewLine}{e.StackTrace}");
                return false;
            }
        }

        private void TryCreateActiveProject(string username, string password)
        {
            this.ActiveProject = new Project(username, password);
        }

        #endregion
    }
}
