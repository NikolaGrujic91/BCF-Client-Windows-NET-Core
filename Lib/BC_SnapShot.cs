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


internal class BC_SnapShot : BC_ControllableData {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BC_SnapShot(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BIMcollab_SnapShotPINVOKE.BC_SnapShot_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BC_SnapShot obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BC_SnapShot() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BIMcollab_SnapShotPINVOKE.delete_BC_SnapShot(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public void SetImage(byte[] pData, uint size) {
    BIMcollab_SnapShotPINVOKE.BC_SnapShot_SetImage(swigCPtr, pData, size);
    if (BIMcollab_SnapShotPINVOKE.SWIGPendingException.Pending) throw BIMcollab_SnapShotPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasImage() {
    bool ret = BIMcollab_SnapShotPINVOKE.BC_SnapShot_HasImage(swigCPtr);
    return ret;
  }

  public void GetImage(byte[] pData, uint size) {
    BIMcollab_SnapShotPINVOKE.BC_SnapShot_GetImage(swigCPtr, pData, size);
    if (BIMcollab_SnapShotPINVOKE.SWIGPendingException.Pending) throw BIMcollab_SnapShotPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetImageSize() {
    uint ret = BIMcollab_SnapShotPINVOKE.BC_SnapShot_GetImageSize(swigCPtr);
    return ret;
  }

  public bool HasThumbnail() {
    bool ret = BIMcollab_SnapShotPINVOKE.BC_SnapShot_HasThumbnail(swigCPtr);
    return ret;
  }

  public void GetThumbnail(byte[] pData, uint size) {
    BIMcollab_SnapShotPINVOKE.BC_SnapShot_GetThumbnail(swigCPtr, pData, size);
    if (BIMcollab_SnapShotPINVOKE.SWIGPendingException.Pending) throw BIMcollab_SnapShotPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetThumbnailSize() {
    uint ret = BIMcollab_SnapShotPINVOKE.BC_SnapShot_GetThumbnailSize(swigCPtr);
    return ret;
  }

  public BC_SnapShot() : this(BIMcollab_SnapShotPINVOKE.new_BC_SnapShot(), true) {
  }

}