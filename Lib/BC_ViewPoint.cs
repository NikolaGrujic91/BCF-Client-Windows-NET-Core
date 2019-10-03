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


internal class BC_ViewPoint : BC_ControllableData {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BC_ViewPoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BC_ViewPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BC_ViewPoint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BIMcollab_ViewPointPINVOKE.delete_BC_ViewPoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public bool HasSnapShot() {
    bool ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_HasSnapShot(swigCPtr);
    return ret;
  }

  public BC_SnapShot GetSnapShot() {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetSnapShot(swigCPtr);
    BC_SnapShot ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_SnapShot(cPtr, false);
    return ret;
  }

  public uint GetNumberOfComponents() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetNumberOfComponents(swigCPtr);
    return ret;
  }

  public uint GetNumberOfComponentsInSource() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetNumberOfComponentsInSource(swigCPtr);
    return ret;
  }

  public void SetNumberOfComponentsToRetrieve(uint numberOfComponents) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetNumberOfComponentsToRetrieve(swigCPtr, numberOfComponents);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsSetNumberOfComponentsToRetrieve() {
    bool ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_IsSetNumberOfComponentsToRetrieve(swigCPtr);
    return ret;
  }

  public void MoveComponentIteratorToFirst() {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_MoveComponentIteratorToFirst(swigCPtr);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool MoveComponentIteratorToNext() {
    bool ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_MoveComponentIteratorToNext(swigCPtr);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool MoveComponentIteratorToIfcGuid(string ifcGuid) {
    bool ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_MoveComponentIteratorToIfcGuid(swigCPtr, ifcGuid);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Component GetComponent() {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetComponent(swigCPtr);
    BC_Component ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Component(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AtLastComponent() {
    bool ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_AtLastComponent(swigCPtr);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Component CreateComponent(string ifcGlobalId, string color, bool selected, bool visible) {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_CreateComponent(swigCPtr, ifcGlobalId, color, selected, visible);
    BC_Component ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Component(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaxNumberOfComponents(uint maxNumberOfComponents) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetMaxNumberOfComponents(swigCPtr, maxNumberOfComponents);
  }

  public bool ContainsComponent(string componentGuid) {
    bool ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_ContainsComponent(swigCPtr, componentGuid);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Component FindComponent(string componentGuid) {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_FindComponent(swigCPtr, componentGuid);
    BC_Component ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Component(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveAllComponents() {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_RemoveAllComponents(swigCPtr);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetProjectionType() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetProjectionType(swigCPtr);
    return ret;
  }

  public void SetProjectionType(uint arg0) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetProjectionType(swigCPtr, arg0);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetOrthogonalCameraDirection() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetOrthogonalCameraDirection(swigCPtr), true);
    return ret;
  }

  public void SetOrthogonalCameraDirection(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetOrthogonalCameraDirection(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetOrthogonalCameraUpVector() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetOrthogonalCameraUpVector(swigCPtr), true);
    return ret;
  }

  public void SetOrthogonalCameraUpVector(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetOrthogonalCameraUpVector(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetOrthogonalCameraViewPoint() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetOrthogonalCameraViewPoint(swigCPtr), true);
    return ret;
  }

  public void SetOrthogonalCameraViewPoint(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetOrthogonalCameraViewPoint(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetOrthogonalCameraViewToWorldScale() {
    double ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetOrthogonalCameraViewToWorldScale(swigCPtr);
    return ret;
  }

  public void SetOrthogonalCameraViewToWorldScale(double scale) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetOrthogonalCameraViewToWorldScale(swigCPtr, scale);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetPerspectiveCameraDirection() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetPerspectiveCameraDirection(swigCPtr), true);
    return ret;
  }

  public void SetPerspectiveCameraDirection(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetPerspectiveCameraDirection(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetPerspectiveCameraUpVector() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetPerspectiveCameraUpVector(swigCPtr), true);
    return ret;
  }

  public void SetPerspectiveCameraUpVector(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetPerspectiveCameraUpVector(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetPerspectiveCameraViewPoint() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetPerspectiveCameraViewPoint(swigCPtr), true);
    return ret;
  }

  public void SetPerspectiveCameraViewPoint(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetPerspectiveCameraViewPoint(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPerspectiveCameraFieldOfView() {
    double ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetPerspectiveCameraFieldOfView(swigCPtr);
    return ret;
  }

  public void SetPerspectiveCameraFieldOfView(double fov) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetPerspectiveCameraFieldOfView(swigCPtr, fov);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetBitmapCenterLocation() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetBitmapCenterLocation(swigCPtr), true);
    return ret;
  }

  public void SetBitmapCenterLocation(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetBitmapCenterLocation(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetBitmapNormalLocation() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetBitmapNormalLocation(swigCPtr), true);
    return ret;
  }

  public void SetBitmapNormalLocation(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetBitmapNormalLocation(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetBitmapUpVectorLocation() {
    BC_3DPoint ret = new BC_3DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetBitmapUpVectorLocation(swigCPtr), true);
    return ret;
  }

  public void SetBitmapUpVectorLocation(BC_3DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetBitmapUpVectorLocation(swigCPtr, BC_3DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDrawingViewportClient() {
    string ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportClient(swigCPtr);
    return ret;
  }

  public void SetDrawingViewportClient(string value) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportClient(swigCPtr, value);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDrawingViewportViewName() {
    string ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportViewName(swigCPtr);
    return ret;
  }

  public void SetDrawingViewportViewName(string value) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportViewName(swigCPtr, value);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetDrawingViewportViewType() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportViewType(swigCPtr);
    return ret;
  }

  public void SetDrawingViewportViewType(uint value) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportViewType(swigCPtr, value);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetDrawingViewportViewStory() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportViewStory(swigCPtr);
    return ret;
  }

  public void SetDrawingViewportViewStory(uint value) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportViewStory(swigCPtr, value);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetDrawingViewportViewID1() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportViewID1(swigCPtr);
    return ret;
  }

  public void SetDrawingViewportViewID1(uint value) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportViewID1(swigCPtr, value);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetDrawingViewportViewID2() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportViewID2(swigCPtr);
    return ret;
  }

  public void SetDrawingViewportViewID2(uint value) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportViewID2(swigCPtr, value);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_2DPoint GetDrawingViewportViewLeftTop() {
    BC_2DPoint ret = new BC_2DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportViewLeftTop(swigCPtr), true);
    return ret;
  }

  public void SetDrawingViewportViewLeftTop(BC_2DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportViewLeftTop(swigCPtr, BC_2DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_2DPoint GetDrawingViewportViewRightBottom() {
    BC_2DPoint ret = new BC_2DPoint(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetDrawingViewportViewRightBottom(swigCPtr), true);
    return ret;
  }

  public void SetDrawingViewportViewRightBottom(BC_2DPoint point) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetDrawingViewportViewRightBottom(swigCPtr, BC_2DPoint.getCPtr(point));
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetNumberOfLines() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetNumberOfLines(swigCPtr);
    return ret;
  }

  public BC_Line GetLineByIndex(uint idx) {
    BC_Line ret = new BC_Line(BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetLineByIndex(swigCPtr, idx), true);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Line CreateLine() {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_CreateLine__SWIG_0(swigCPtr);
    BC_Line ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Line(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_Line CreateLine(BC_3DPoint startPoint, BC_3DPoint endPoint) {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_CreateLine__SWIG_1(swigCPtr, BC_3DPoint.getCPtr(startPoint), BC_3DPoint.getCPtr(endPoint));
    BC_Line ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_Line(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveLineByIndex(uint idx) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_RemoveLineByIndex(swigCPtr, idx);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetNumberOfClippingPlanes() {
    uint ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetNumberOfClippingPlanes(swigCPtr);
    return ret;
  }

  public BC_ClippingPlane GetClippingPlaneByIndex(uint idx) {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetClippingPlaneByIndex(swigCPtr, idx);
    BC_ClippingPlane ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_ClippingPlane(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_ClippingPlane CreateClippingPlane() {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_CreateClippingPlane__SWIG_0(swigCPtr);
    BC_ClippingPlane ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_ClippingPlane(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BC_ClippingPlane CreateClippingPlane(BC_3DPoint direction, BC_3DPoint location) {
    global::System.IntPtr cPtr = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_CreateClippingPlane__SWIG_1(swigCPtr, BC_3DPoint.getCPtr(direction), BC_3DPoint.getCPtr(location));
    BC_ClippingPlane ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_ClippingPlane(cPtr, false);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveClippingPlaneByIndex(uint idx) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_RemoveClippingPlaneByIndex(swigCPtr, idx);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetGuid() {
    string ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetGuid(swigCPtr);
    return ret;
  }

  public void StartComponentAddition(uint nrComponents) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_StartComponentAddition(swigCPtr, nrComponents);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public void FinalizeComponentAddition() {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_FinalizeComponentAddition(swigCPtr);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetViewSetupHint(BC_ViewSetupHint viewSetupHint) {
    bool ret = BIMcollab_ViewPointPINVOKE.BC_ViewPoint_GetViewSetupHint(swigCPtr, (int)viewSetupHint);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetViewSetupHint(BC_ViewSetupHint viewSetupHint, bool isVisible) {
    BIMcollab_ViewPointPINVOKE.BC_ViewPoint_SetViewSetupHint(swigCPtr, (int)viewSetupHint, isVisible);
    if (BIMcollab_ViewPointPINVOKE.SWIGPendingException.Pending) throw BIMcollab_ViewPointPINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_ViewPoint() : this(BIMcollab_ViewPointPINVOKE.new_BC_ViewPoint(), true) {
  }

}