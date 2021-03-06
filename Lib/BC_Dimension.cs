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


internal class BC_Dimension : BC_ControllableData {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BC_Dimension(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BIMcollab_DimensionPINVOKE.BC_Dimension_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BC_Dimension obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BC_Dimension() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BIMcollab_DimensionPINVOKE.delete_BC_Dimension(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BC_Dimension() : this(BIMcollab_DimensionPINVOKE.new_BC_Dimension(), true) {
  }

  public BC_3DPoint GetFirstPoint() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetFirstPoint(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public BC_3DPoint GetFirstNormal() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetFirstNormal(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public BC_3DPoint GetFirstVector() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetFirstVector(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public uint GetFirstType() {
    uint ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetFirstType(swigCPtr);
    return ret;
  }

  public BC_3DPoint GetSecondPoint() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetSecondPoint(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public BC_3DPoint GetSecondNormal() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetSecondNormal(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public BC_3DPoint GetSecondVector() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetSecondVector(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public uint GetSecondType() {
    uint ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetSecondType(swigCPtr);
    return ret;
  }

  public bool GetIsPointToPoint() {
    bool ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetIsPointToPoint(swigCPtr);
    return ret;
  }

  public BC_3DPoint GetUpVector() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetUpVector(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public BC_3DPoint GetDirToCameraVector() {
    global::System.IntPtr cPtr = BIMcollab_DimensionPINVOKE.BC_Dimension_GetDirToCameraVector(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public string GetColor() {
    string ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetColor(swigCPtr);
    return ret;
  }

  public double GetLineWidth() {
    double ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetLineWidth(swigCPtr);
    return ret;
  }

  public double GetTextHeight() {
    double ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetTextHeight(swigCPtr);
    return ret;
  }

  public uint GetFirstPointSymbol() {
    uint ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetFirstPointSymbol(swigCPtr);
    return ret;
  }

  public uint GetSecondPointSymbol() {
    uint ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetSecondPointSymbol(swigCPtr);
    return ret;
  }

  public double GetEndPointSymbolHeight() {
    double ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetEndPointSymbolHeight(swigCPtr);
    return ret;
  }

  public void SetFirstPoint(BC_3DPoint point, BC_3DPoint normal, BC_3DPoint vector, uint type) {
    BIMcollab_DimensionPINVOKE.BC_Dimension_SetFirstPoint(swigCPtr, BC_3DPoint.getCPtr(point), BC_3DPoint.getCPtr(normal), BC_3DPoint.getCPtr(vector), type);
    if (BIMcollab_DimensionPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DimensionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSecondPoint(BC_3DPoint point, BC_3DPoint normal, BC_3DPoint vector, uint type) {
    BIMcollab_DimensionPINVOKE.BC_Dimension_SetSecondPoint(swigCPtr, BC_3DPoint.getCPtr(point), BC_3DPoint.getCPtr(normal), BC_3DPoint.getCPtr(vector), type);
    if (BIMcollab_DimensionPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DimensionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAdditionalParameters(bool isPointToPoint, BC_3DPoint upVector, BC_3DPoint dirToCameraVector, string color, double lineWidth, double textHeight, uint lineFirstPointSymbol, uint lineSecondPointSymbol, double EndPointSymbolHeight) {
    BIMcollab_DimensionPINVOKE.BC_Dimension_SetAdditionalParameters(swigCPtr, isPointToPoint, BC_3DPoint.getCPtr(upVector), BC_3DPoint.getCPtr(dirToCameraVector), color, lineWidth, textHeight, lineFirstPointSymbol, lineSecondPointSymbol, EndPointSymbolHeight);
    if (BIMcollab_DimensionPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DimensionPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetExtendedData() {
    string ret = BIMcollab_DimensionPINVOKE.BC_Dimension_GetExtendedData(swigCPtr);
    return ret;
  }

  public void SetExtendedData(string data) {
    BIMcollab_DimensionPINVOKE.BC_Dimension_SetExtendedData(swigCPtr, data);
    if (BIMcollab_DimensionPINVOKE.SWIGPendingException.Pending) throw BIMcollab_DimensionPINVOKE.SWIGPendingException.Retrieve();
  }

}
