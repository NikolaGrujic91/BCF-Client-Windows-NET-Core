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


internal class BC_DataModel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BC_DataModel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BC_DataModel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BC_DataModel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BIMcollab_DataModelPINVOKE.delete_BC_DataModel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static BC_DataModel GetInstance() {
    global::System.IntPtr cPtr = BIMcollab_DataModelPINVOKE.BC_DataModel_GetInstance();
    BC_DataModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_DataModel(cPtr, false);
    return ret;
  }

  public string GetAPIVersionString() {
    string ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetAPIVersionString(swigCPtr);
    return ret;
  }

  public string GetWSVersionString() {
    string ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetWSVersionString(swigCPtr);
    return ret;
  }

  public string GetDBVersionString() {
    string ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetDBVersionString(swigCPtr);
    return ret;
  }

  public void SetActiveUser(string userLastName, string userFirstName, string userPassword, string userEmail, string userInitials) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_SetActiveUser(swigCPtr, userLastName, userFirstName, userPassword, userEmail, userInitials);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Connect(string server, string token) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_Connect(swigCPtr, server, token);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetNumberOfProjects() {
    uint ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetNumberOfProjects(swigCPtr);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Project GetProjectByIndex(uint idx) {
    global::System.IntPtr cPtr = BIMcollab_DataModelPINVOKE.BC_DataModel_GetProjectByIndex(swigCPtr, idx);
    BC_Project ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Project(cPtr, false);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SelectProjectByIndex(uint idx) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_SelectProjectByIndex(swigCPtr, idx);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetIssueSelectionFilter(bool mineOnly, bool active, bool resolved, bool closed) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_SetIssueSelectionFilter(swigCPtr, mineOnly, active, resolved, closed);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_Project GetActiveProject() {
    global::System.IntPtr cPtr = BIMcollab_DataModelPINVOKE.BC_DataModel_GetActiveProject(swigCPtr);
    BC_Project ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Project(cPtr, false);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Discard() {
    BIMcollab_DataModelPINVOKE.BC_DataModel_Discard(swigCPtr);
  }

  public uint GetTimestampFormatMode() {
    uint ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetTimestampFormatMode(swigCPtr);
    return ret;
  }

  public string GetTimestampFormatString() {
    string ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetTimestampFormatString(swigCPtr);
    return ret;
  }

  public void SetTimestampFormat(uint mode, string format) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_SetTimestampFormat__SWIG_0(swigCPtr, mode, format);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTimestampFormat(uint mode) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_SetTimestampFormat__SWIG_1(swigCPtr, mode);
  }

  public void SetProxy(string host, uint port, string user, string password) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_SetProxy(swigCPtr, host, port, user, password);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ForceProxy(string host, uint port, string user, string password) {
    BIMcollab_DataModelPINVOKE.BC_DataModel_ForceProxy(swigCPtr, host, port, user, password);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearProxy() {
    BIMcollab_DataModelPINVOKE.BC_DataModel_ClearProxy(swigCPtr);
  }

  public int TestConnection(string server) {
    int ret = BIMcollab_DataModelPINVOKE.BC_DataModel_TestConnection(swigCPtr, server);
    if (BIMcollab_DataModelPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DataModelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDefaultMaxNumberOfComponentsInViewpoint() {
    uint ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetDefaultMaxNumberOfComponentsInViewpoint(swigCPtr);
    return ret;
  }

  public uint GetMaxNumberOfLinesInViewpoint() {
    uint ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetMaxNumberOfLinesInViewpoint(swigCPtr);
    return ret;
  }

  public uint GetMaxNumberOfClippingPlanesInViewpoint() {
    uint ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetMaxNumberOfClippingPlanesInViewpoint(swigCPtr);
    return ret;
  }

  public uint GetMaxNumberOfAnnotationsInViewpoint() {
    uint ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetMaxNumberOfAnnotationsInViewpoint(swigCPtr);
    return ret;
  }

  public uint GetMaxNumberOfDimensionsInViewpoint() {
    uint ret = BIMcollab_DataModelPINVOKE.BC_DataModel_GetMaxNumberOfDimensionsInViewpoint(swigCPtr);
    return ret;
  }

  public bool IsPublishActive() {
    bool ret = BIMcollab_DataModelPINVOKE.BC_DataModel_IsPublishActive(swigCPtr);
    return ret;
  }

  public void WaitForPublishToFinish() {
    BIMcollab_DataModelPINVOKE.BC_DataModel_WaitForPublishToFinish(swigCPtr);
  }

  public BC_DataModel() : this(BIMcollab_DataModelPINVOKE.new_BC_DataModel(), true) {
  }

}
