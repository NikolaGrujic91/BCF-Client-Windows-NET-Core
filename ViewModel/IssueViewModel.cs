using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Data;
using BIMcollab_BCF_WPF_MVVM.Model;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal class IssueViewModel
    {
        #region Fields

        private string publishMessage;
        private Project activeProject;
        private readonly CollectionViewSource issuesViewSource;

        private readonly string settingsShowActive = "ShowActive";
        private readonly string settingsShowResolved = "ShowResolved";
        private readonly string settingsShowClosed = "ShowClosed";
        private readonly string settingsTrue = "true";
        private readonly string settingsFalse = "false";

        #endregion

        #region Constructors

        public IssueViewModel()
        {
            this.LoadFilterSettings();

            this.Issues = new ObservableCollection<Issue>();
            this.issuesViewSource = new CollectionViewSource();
            this.issuesViewSource.Filter += this.IssuesView_Filter;
            this.issuesViewSource.Source = this.Issues;
            this.publishMessage = string.Empty;
        }

        #endregion

        #region Properties

        public ObservableCollection<Issue> Issues { get; set; }

        public ICollectionView IssuesView
        {
            get { return this.issuesViewSource.View;}
        }

        public bool ShowActive { get; set; }

        public bool ShowResolved { get; set; }

        public bool ShowClosed { get; set; }

        #endregion

        #region Events

        private void IssuesView_Filter(object sender, FilterEventArgs e)
        {
            var issue = e.Item as Issue;

            if (issue == null)
            {
                return;
            }

            uint issueStatusActive = 0;

            if (issue.StatusID == issueStatusActive && this.ShowActive)
            {
                e.Accepted = true;
                return;
            }

            uint issueStatusResolved = 1;

            if (issue.StatusID == issueStatusResolved && this.ShowResolved)
            {
                e.Accepted = true;
                return;
            }

            uint issueStatusClosed = 2;

            if (issue.StatusID == issueStatusClosed && this.ShowClosed)
            {
                e.Accepted = true;
                return;
            }

            e.Accepted = false;
        }

        #endregion

        #region Methods

        public void Publish()
        {
            bool result = this.activeProject.Publish();

            this.publishMessage = result ? "Publishing Successful" : this.activeProject.ErrorMessage();
        }

        public void LoadIssues(Project project)
        {
            this.activeProject = project;
            this.GetIssues();
        }

        public void AddIssue(Issue newIssue)
        {
            this.Issues.Add(newIssue);
        }

        public string GetPublishMessage()
        {
            return this.publishMessage;
        }

        public void Refresh()
        {
            this.IssuesView.Refresh();
        }

        public Issue GetCurrentIssue()
        {
            return (Issue) this.IssuesView.CurrentItem;
        }

        public void SaveFilterSettings()
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            settings[this.settingsShowActive].Value   = this.ShowActive ? this.settingsTrue : this.settingsFalse;
            settings[this.settingsShowResolved].Value = this.ShowResolved ? this.settingsTrue : this.settingsFalse;
            settings[this.settingsShowClosed].Value   = this.ShowClosed ? this.settingsTrue : this.settingsFalse;

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void LoadFilterSettings()
        {
            this.ShowActive   = ConfigurationManager.AppSettings[this.settingsShowActive].Equals(this.settingsTrue);
            this.ShowResolved = ConfigurationManager.AppSettings[this.settingsShowResolved].Equals(this.settingsTrue);
            this.ShowClosed   = ConfigurationManager.AppSettings[this.settingsShowClosed].Equals(this.settingsTrue);
        }

        private void GetIssues()
        {
            List<string> milestones = this.activeProject.Milestones;
            List<string> areas = this.activeProject.Areas;
            List<string> labels = this.activeProject.Labels;
            List<string> types = this.activeProject.Types;
            List<string> priorities = this.activeProject.Priorities;
            List<string> statuses = this.activeProject.Statuses;

            uint numberOfIssues = this.activeProject.GetNumberOfIssues();

            for (uint i = 0; i < numberOfIssues; i++)
            {
                BC_Issue issue = this.activeProject.GetIssueByIndex(i);
                this.Issues.Add(new Issue(issue, ref milestones, ref areas, ref labels, ref types, ref priorities, ref statuses));
            }
        }

        #endregion
    }
}
