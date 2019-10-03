using System.Collections.Generic;
using System.Windows;
using BIMcollab_BCF_WPF_MVVM.Model;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal abstract class EditIssueAbstractViewModel
    {
        #region Fields

        private const uint issueStatusActive = 0;
        private const uint issueStatusResolved = 1;
        private const uint issueStatusClosed = 2;

        protected Project activeProject;
        protected Issue issue;

        #endregion

        #region Properties

        public List<string> Milestones
        {
            get { return this.activeProject.Milestones; }
        }

        public List<string> Areas
        {
            get { return this.activeProject.Areas; }
        }

        public List<string> Labels
        {
            get { return this.activeProject.Labels; }
        }

        public List<string> Types
        {
            get { return this.activeProject.Types; }
        }

        public List<string> Priorities
        {
            get { return this.activeProject.Priorities; }
        }

        public List<string> Users
        {
            get { return this.activeProject.Users; }
        }

        public List<string> Visibilities
        {
            get { return this.activeProject.Visibilities; }
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ActiveStatus { get; set; }

        public int ActiveType { get; set; }

        public int ActiveMilestone { get; set; }

        public int ActiveArea { get; set; }

        public int ActivePriority { get; set; }

        public int ActiveVisibility { get; set; }

        public int OwnerIndex { get; set; }

        public uint StatusID { get; set; }

        public bool NewIssueCreated
        {
            get { return this.IsNewIssueCreated(); }
        }

        public Visibility ResolvedButtonVisible
        {
            get { return this.IsResolvedButtonVisible(); }
        }

        public Visibility ResolveAndCloseButtonVisible
        {
            get { return this.IsResolveAndCloseButtonVisible(); }
        }

        public Visibility CloseButtonVisible
        {
            get { return this.IsCloseButtonVisible(); }
        }

        public Visibility ReopenButtonVisible
        {
            get { return this.IsReopenButtonVisible(); }
        }

        public Visibility ReactivateButtonVisible
        {
            get { return this.IsReactivateButtonVisible(); }
        }

        public bool TypeComboBoxEnabled
        {
            get { return this.IsTypeComboBoxEnabled(); }
        }

        public bool AreaComboBoxEnabled
        {
            get { return this.IsAreaComboBoxEnabled(); }
        }

        public bool MilestoneComboBoxEnabled
        {
            get { return this.IsMilestoneComboBoxEnabled(); }
        }

        public bool PriorityComboBoxEnabled
        {
            get { return this.IsPriorityComboBoxEnabled(); }
        }

        public bool AssignedComboBoxEnabled
        {
            get { return this.IsAssignedComboBoxEnabled(); }
        }

        public bool VisibilityComboBoxEnabled
        {
            get { return this.IsVisibilityComboBoxEnabled(); }
        }

        public bool DescriptionTextBoxEnabled
        {
            get { return this.IsDescriptionTextBoxEnabled(); }
        }

        public bool TitleTextBoxEnabled
        {
            get { return this.IsTitleTextBoxEnabled(); }
        }

        #endregion

        #region Methods

        public void EditIssue(Issue editedIssue)
        {
            this.issue = editedIssue;
            this.Load();
        }

        public void CreateNewIssue()
        {
            List<string> milestones = this.activeProject.Milestones;
            List<string> areas = this.activeProject.Areas;
            List<string> labels = this.activeProject.Labels;
            List<string> types = this.activeProject.Types;
            List<string> priorities = this.activeProject.Priorities;
            List<string> statuses = this.activeProject.Statuses;

            BC_Issue newIssue = this.activeProject.CreateIssue();

            this.issue = new Issue(newIssue, ref milestones, ref areas, ref labels, ref types, ref priorities, ref statuses);
            this.issue.CreateDefaultComment();
            this.Load();
        }

        public void SetStatusActive()
        {
            this.StatusID = issueStatusActive;
            this.UpdateActiveStatus();
        }

        public void SetStatusClosed()
        {
            this.StatusID = issueStatusClosed;
            this.UpdateActiveStatus();
        }

        public void SetStatusResolved()
        {
            this.StatusID = issueStatusResolved;
            this.UpdateActiveStatus();
        }

        public Issue GetEditedIssue()
        {
            return this.issue;
        }

        public void Save()
        {
            this.issue.Title = this.Title;
            this.issue.Description = this.Description;
            this.issue.StatusID = this.StatusID;
            this.issue.TypeID = (uint) this.ActiveType;
            this.issue.MilestoneID = (uint) this.ActiveMilestone;
            this.issue.AreaID = (uint) this.ActiveArea;
            this.issue.PriorityID = (uint) this.ActivePriority;
            this.issue.VisibilityID = (uint) this.ActiveVisibility;
            this.issue.OwnerIndex = (uint) this.OwnerIndex;

            List<string> statuses = this.activeProject.Statuses;

            this.issue.Status = statuses[(int)this.issue.StatusID];
            this.issue.Type = this.Types[(int) this.issue.TypeID];
            this.issue.Area = this.Areas[(int) this.issue.AreaID];
            this.issue.Milestone = this.Milestones[(int) this.issue.MilestoneID];
            this.issue.Priority = this.Priorities[(int) this.issue.PriorityID];

            this.issue.IncludeInPublish();
        }

        private void Load()
        {
            this.Title = this.issue.Title;
            this.Description = this.issue.Description;
            this.ActiveStatus = this.GetActiveStatus();
            this.ActiveType = this.GetActiveType();
            this.ActiveMilestone = this.GetActiveMilestone();
            this.ActiveArea = this.GetActiveArea();
            this.ActivePriority = this.GetActivePriority();
            this.ActiveVisibility = this.GetActiveVisibility();
            this.OwnerIndex = this.GetOwnerIndex();
            this.StatusID = this.issue.StatusID;
        }

        private Visibility IsResolvedButtonVisible()
        {
            bool resolvedButtonEnabled = this.StatusID == issueStatusActive &&
                                         this.issue.IsOperationAllowed((uint)BC_Operation.operationIssueChangeStatus, issueStatusResolved) &&
                                         this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeStatus);

            return resolvedButtonEnabled ? Visibility.Visible : Visibility.Collapsed;
        }

        private Visibility IsResolveAndCloseButtonVisible()
        {
            bool resolveAndCloseButtonEnabled = this.StatusID == issueStatusActive &&
                                                this.issue.IsOperationAllowed((uint)BC_Operation.operationIssueChangeStatus, issueStatusClosed) &&
                                                this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeStatus);

            return resolveAndCloseButtonEnabled ? Visibility.Visible : Visibility.Collapsed;
        }

        private Visibility IsCloseButtonVisible()
        {
            bool closeButtonEnabled = this.StatusID == issueStatusResolved &&
                                      this.issue.IsOperationAllowed((uint)BC_Operation.operationIssueChangeStatus, issueStatusClosed) &&
                                      this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeStatus);

            return closeButtonEnabled ? Visibility.Visible : Visibility.Collapsed;
        }

        private Visibility IsReopenButtonVisible()
        {
            bool reopenButtonEnabled = this.StatusID == issueStatusClosed &&
                                       this.issue.IsOperationAllowed((uint)BC_Operation.operationIssueChangeStatus, issueStatusActive) &&
                                       this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeStatus);

            return reopenButtonEnabled ? Visibility.Visible : Visibility.Collapsed;
        }

        private Visibility IsReactivateButtonVisible()
        {
            bool reactivateButtonEnabled = this.StatusID == issueStatusResolved &&
                                           this.issue.IsOperationAllowed((uint)BC_Operation.operationIssueChangeStatus, issueStatusActive) &&
                                           this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeStatus);

            return reactivateButtonEnabled ? Visibility.Visible : Visibility.Collapsed;
        }

        private bool IsTypeComboBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeType);
        }

        private bool IsAreaComboBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeArea);
        }

        private bool IsMilestoneComboBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeMilestone);
        }

        private bool IsPriorityComboBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangePriority);
        }

        private bool IsAssignedComboBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeOwner);
        }

        private bool IsVisibilityComboBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeVisibility);
        }

        private bool IsDescriptionTextBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeDescription);
        }

        private bool IsTitleTextBoxEnabled()
        {
            return this.issue.IsOperationAllowed(BC_Operation.operationIssueChangeTitle);
        }

        private void UpdateActiveStatus()
        {
            this.ActiveStatus = this.activeProject.Statuses[(int) this.StatusID];
        }

        #endregion

        #region Abstract Methods

        protected abstract string GetActiveStatus();

        protected abstract int GetActiveType();

        protected abstract int GetActiveMilestone();

        protected abstract int GetActiveArea();

        protected abstract int GetActivePriority();

        protected abstract int GetOwnerIndex();

        protected abstract int GetActiveVisibility();

        protected abstract bool IsNewIssueCreated();

        #endregion
    }
}
