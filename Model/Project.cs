using System;
using System.Collections.Generic;
using BIMcollab_BCF_WPF_MVVM.Utility;

namespace BIMcollab_BCF_WPF_MVVM.Model
{
    internal class Project
    {
        #region Fields

        private readonly BC_Project project;

        #endregion

        #region Constructors

        public Project(string username, string password)
        {
            BC_DataModel dataModel = BC_DataModel.GetInstance();

            dataModel.SetActiveUser(string.Empty,
                                    string.Empty,
                                    password,
                                    username,
                                    string.Empty);

            dataModel.Connect("playground.bimcollab.com", "460C8E9C-20E4-4188-BCA2-8E34F464C026");

            dataModel.SelectProjectByIndex(0);

            this.project = dataModel.GetActiveProject();

            this.GetMilestones();
            this.GetAreas();
            this.GetLabels();
            this.GetTypes();
            this.GetPriorities();
            this.GetStatuses();
            this.GetUsers();
            this.GetVisibilities();
        }

        #endregion

        #region Properties

        public string Title
        {
            get { return this.project.GetTitle(); }
        }

        public List<string> Milestones { get; private set; }

        public List<string> Areas { get; private set; }

        public List<string> Labels { get; private set; }

        public List<string> Types { get; private set; }

        public List<string> Priorities { get; private set; }

        public List<string> Statuses { get; private set; }

        public List<string> Users { get; private set; }

        public List<string> Visibilities { get; private set; }

        public int DefaultIssueType
        {
            get { return (int)this.project.GetDefaultIssueTypeIndex(); }
        }

        public string DefaultStatusType
        {
            get { return this.Statuses[(int)this.project.GetDefaultIssueStatusIndex()]; }
        }

        public int DefaultPriorityType
        {
            get { return (int)this.project.GetDefaultIssuePriorityIndex(); }
        }

        public string ApiVersion
        {
            get { return BC_DataModel.GetInstance().GetAPIVersionString(); }
        }

        public string WebServiceVersion
        {
            get { return BC_DataModel.GetInstance().GetWSVersionString(); }
        }

        public string DatabaseVersion
        {
            get { return BC_DataModel.GetInstance().GetDBVersionString(); }
        }

        #endregion

        #region Methods

        public uint GetNumberOfIssues()
        {
            return this.project.GetNumberOfIssues();
        }

        public BC_Issue GetIssueByIndex(uint index)
        {
            return this.project.GetIssueByIndex(index);
        }

        public string ErrorMessage()
        {
            if (this.project.HasActiveError())
            {
                BC_Message message = this.project.GetActiveError();

                return message.GetText();
            }

            return string.Empty;
        }

        public BC_Issue CreateIssue()
        {
            return this.project.CreateIssue();
        }

        public bool Publish()
        {
            try
            {
                return this.TryPublish();
            }
            catch (Exception e)
            {
                LogWriter.LogWrite($"{e.Message}{Environment.NewLine}{e.StackTrace}");
                return false;
            }
        }

        private bool TryPublish()
        {
            return this.project.Publish();
        }

        private void GetMilestones()
        {
            this.Milestones = new List<string>();
            uint numberOfStatuses = this.project.GetNumberOfMilestones();

            for (uint i = 0; i < numberOfStatuses; i++)
            {
                string status = this.project.GetMilestoneLabelByIndex(i);
                this.Milestones.Add(status);
            }
        }

        private void GetAreas()
        {
            this.Areas = new List<string>();
            uint numberOfAreas = this.project.GetNumberOfAreas();

            for (uint i = 0; i < numberOfAreas; i++)
            {
                string area = this.project.GetAreaLabelByIndex(i);
                this.Areas.Add(area);
            }
        }

        private void GetLabels()
        {
            this.Labels = new List<string>();
            uint numberOfLabels = this.project.GetNumberOfIssueLabels();

            for (uint i = 0; i < numberOfLabels; i++)
            {
                string label = this.project.GetIssueLabelLabelByIndex(i);
                this.Labels.Add(label);
            }
        }

        private void GetTypes()
        {
            this.Types = new List<string>();
            uint numberOfTypes = this.project.GetNumberOfIssueTypes();

            for (uint i = 0; i < numberOfTypes; i++)
            {
                string type = this.project.GetIssueTypeLabelByIndex(i);
                this.Types.Add(type);
            }
        }

        private void GetPriorities()
        {
            this.Priorities = new List<string>();
            uint numberOfPriorities = this.project.GetNumberOfIssuePriorities();

            for (uint i = 0; i < numberOfPriorities; i++)
            {
                string priority = this.project.GetIssuePriorityLabelByIndex(i);
                this.Priorities.Add(priority);
            }
        }

        private void GetStatuses()
        {
            this.Statuses = new List<string>();
            uint numberOfStatuses = this.project.GetNumberOfIssueStatuses();

            for (uint i = 0; i < numberOfStatuses; i++)
            {
                string status = this.project.GetIssueStatusLabelByIndex(i);
                this.Statuses.Add(status);
            }
        }

        private void GetUsers()
        {
            this.Users = new List<string>();

            uint numberOfProjectUsers = this.project.GetNumberOfUsers();

            for (uint i = 0; i < numberOfProjectUsers; i++)
            {
                BC_User user = this.project.GetUserByIndex(i);

                if (user.CanBecomeOwner())
                {
                    this.Users.Add($"{user.GetFirstName()} {user.GetLastName()}");
                }
            }
        }

        private void GetVisibilities()
        {
            this.Visibilities = new List<string>();

            uint numberOfVisibilities = this.project.GetNumberOfIssueVisibilities();

            for (uint i = 0; i < numberOfVisibilities; i++)
            {
                string visibility = this.project.GetIssueVisibilityLabelByIndex(i);
                this.Visibilities.Add(visibility);
            }
        }

        #endregion
    }
}
