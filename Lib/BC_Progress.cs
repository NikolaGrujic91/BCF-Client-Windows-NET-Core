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


internal class BC_Progress : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BC_Progress(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BC_Progress obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BC_Progress() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BIMcollab_ProjectPINVOKE.delete_BC_Progress(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint action {
    set {
      BIMcollab_ProjectPINVOKE.BC_Progress_action_set(swigCPtr, value);
    } 
    get {
      uint ret = BIMcollab_ProjectPINVOKE.BC_Progress_action_get(swigCPtr);
      return ret;
    } 
  }

  public uint index {
    set {
      BIMcollab_ProjectPINVOKE.BC_Progress_index_set(swigCPtr, value);
    } 
    get {
      uint ret = BIMcollab_ProjectPINVOKE.BC_Progress_index_get(swigCPtr);
      return ret;
    } 
  }

  public uint nrTotal {
    set {
      BIMcollab_ProjectPINVOKE.BC_Progress_nrTotal_set(swigCPtr, value);
    } 
    get {
      uint ret = BIMcollab_ProjectPINVOKE.BC_Progress_nrTotal_get(swigCPtr);
      return ret;
    } 
  }

  public uint nrFailed {
    set {
      BIMcollab_ProjectPINVOKE.BC_Progress_nrFailed_set(swigCPtr, value);
    } 
    get {
      uint ret = BIMcollab_ProjectPINVOKE.BC_Progress_nrFailed_get(swigCPtr);
      return ret;
    } 
  }

  public BC_Progress() : this(BIMcollab_ProjectPINVOKE.new_BC_Progress(), true) {
  }

}