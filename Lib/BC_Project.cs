// <auto-generated/>
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


internal class BC_Project : BC_ControllableData {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BC_Project(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BIMcollab_ProjectPINVOKE.BC_Project_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BC_Project obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BC_Project() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BIMcollab_ProjectPINVOKE.delete_BC_Project(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint GetNumberOfIssues() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfIssues(swigCPtr);
    return ret;
  }

  public BC_Issue GetIssueByIndex(uint idx) {
    global::System.IntPtr cPtr = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueByIndex(swigCPtr, idx);
    BC_Issue ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Issue(cPtr, false);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetNumberOfUsers() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfUsers(swigCPtr);
    return ret;
  }

  public BC_User GetUserByIndex(uint idx) {
    global::System.IntPtr cPtr = BIMcollab_ProjectPINVOKE.BC_Project_GetUserByIndex(swigCPtr, idx);
    BC_User ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_User(cPtr, false);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetTitle() {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetTitle(swigCPtr);
    return ret;
  }

  public string GetDescription() {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetDescription(swigCPtr);
    return ret;
  }

  public string GetId() {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetId(swigCPtr);
    return ret;
  }

  public string GetStartDate() {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetStartDate(swigCPtr);
    return ret;
  }

  public string GetEndDate() {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetEndDate(swigCPtr);
    return ret;
  }

  public void Reload() {
    BIMcollab_ProjectPINVOKE.BC_Project_Reload(swigCPtr);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Refresh() {
    BIMcollab_ProjectPINVOKE.BC_Project_Refresh(swigCPtr);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Publish() {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_Publish(swigCPtr);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Issue CreateIssue() {
    global::System.IntPtr cPtr = BIMcollab_ProjectPINVOKE.BC_Project_CreateIssue(swigCPtr);
    BC_Issue ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Issue(cPtr, false);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanRemoveIssueByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_CanRemoveIssueByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveIssueByIndex(uint idx) {
    BIMcollab_ProjectPINVOKE.BC_Project_RemoveIssueByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsOperationAllowed(BC_Operation operation) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_IsOperationAllowed(swigCPtr, (int)operation);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Progress GetProgress() {
    BC_Progress ret = new BC_Progress(BIMcollab_ProjectPINVOKE.BC_Project_GetProgress(swigCPtr), true);
    return ret;
  }

  public uint GetNumberOfAreas() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfAreas(swigCPtr);
    return ret;
  }

  public string GetAreaLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetAreaLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetAreaActiveByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_GetAreaActiveByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetNumberOfMilestones() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfMilestones(swigCPtr);
    return ret;
  }

  public string GetMilestoneLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetMilestoneLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetMilestoneActiveByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_GetMilestoneActiveByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetActiveUser(string userLastName, string userFirstName, string userPassword, string userEmail, string userInitials) {
    BIMcollab_ProjectPINVOKE.BC_Project_SetActiveUser(swigCPtr, userLastName, userFirstName, userPassword, userEmail, userInitials);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasActiveError() {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_HasActiveError(swigCPtr);
    return ret;
  }

  public BC_Message GetActiveError() {
    global::System.IntPtr cPtr = BIMcollab_ProjectPINVOKE.BC_Project_GetActiveError(swigCPtr);
    BC_Message ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Message(cPtr, false);
    return ret;
  }

  public uint GetNumberOfMessages() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfMessages(swigCPtr);
    return ret;
  }

  public BC_Message GetMessageByIndex(uint idx) {
    global::System.IntPtr cPtr = BIMcollab_ProjectPINVOKE.BC_Project_GetMessageByIndex(swigCPtr, idx);
    BC_Message ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Message(cPtr, false);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetNumberOfIssueStatuses() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfIssueStatuses(swigCPtr);
    return ret;
  }

  public string GetIssueStatusLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueStatusLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIssueStatusActiveByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueStatusActiveByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDefaultIssueStatusIndex() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetDefaultIssueStatusIndex(swigCPtr);
    return ret;
  }

  public uint GetNumberOfIssuePriorities() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfIssuePriorities(swigCPtr);
    return ret;
  }

  public string GetIssuePriorityLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssuePriorityLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIssuePriorityActiveByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssuePriorityActiveByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDefaultIssuePriorityIndex() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetDefaultIssuePriorityIndex(swigCPtr);
    return ret;
  }

  public uint GetNumberOfIssueLabels() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfIssueLabels(swigCPtr);
    return ret;
  }

  public string GetIssueLabelLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueLabelLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIssueLabelActiveByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueLabelActiveByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetNumberOfIssueTypes() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfIssueTypes(swigCPtr);
    return ret;
  }

  public string GetIssueTypeLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueTypeLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIssueTypeActiveByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueTypeActiveByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDefaultIssueTypeIndex() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetDefaultIssueTypeIndex(swigCPtr);
    return ret;
  }

  public uint GetNumberOfIssueVisibilities() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfIssueVisibilities(swigCPtr);
    return ret;
  }

  public string GetIssueVisibilityLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueVisibilityLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIssueVisibilityActiveByIndex(uint idx) {
    bool ret = BIMcollab_ProjectPINVOKE.BC_Project_GetIssueVisibilityActiveByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDefaultIssueVisibilityIndex() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetDefaultIssueVisibilityIndex(swigCPtr);
    return ret;
  }

  public uint GetNumberOfProjectionTypes() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetNumberOfProjectionTypes(swigCPtr);
    return ret;
  }

  public string GetProjectionTypeLabelByIndex(uint idx) {
    string ret = BIMcollab_ProjectPINVOKE.BC_Project_GetProjectionTypeLabelByIndex(swigCPtr, idx);
    if (BIMcollab_ProjectPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ProjectPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDefaultProjectionTypeIndex() {
    uint ret = BIMcollab_ProjectPINVOKE.BC_Project_GetDefaultProjectionTypeIndex(swigCPtr);
    return ret;
  }

  public BC_Project() : this(BIMcollab_ProjectPINVOKE.new_BC_Project(), true) {
  }

}
