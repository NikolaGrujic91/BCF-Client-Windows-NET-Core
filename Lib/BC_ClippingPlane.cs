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


internal class BC_ClippingPlane : BC_ControllableData {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BC_ClippingPlane(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BIMcollab_ClippingPlanePINVOKE.BC_ClippingPlane_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BC_ClippingPlane obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BC_ClippingPlane() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BIMcollab_ClippingPlanePINVOKE.delete_BC_ClippingPlane(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BC_ClippingPlane(BC_3DPoint direction, BC_3DPoint location) : this(BIMcollab_ClippingPlanePINVOKE.new_BC_ClippingPlane(BC_3DPoint.getCPtr(direction), BC_3DPoint.getCPtr(location)), true) {
    if (BIMcollab_ClippingPlanePINVOKE.SWIGPendingException.Pending) throw BIMcollab_ClippingPlanePINVOKE.SWIGPendingException.Retrieve();
  }

  public BC_3DPoint GetDirection() {
    global::System.IntPtr cPtr = BIMcollab_ClippingPlanePINVOKE.BC_ClippingPlane_GetDirection(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

  public BC_3DPoint GetLocation() {
    global::System.IntPtr cPtr = BIMcollab_ClippingPlanePINVOKE.BC_ClippingPlane_GetLocation(swigCPtr);
    BC_3DPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new BC_3DPoint(cPtr, false);
    return ret;
  }

}
