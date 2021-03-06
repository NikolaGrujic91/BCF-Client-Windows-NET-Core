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


[System.CodeDom.Compiler.GeneratedCode("SWIG", "3.0.2")]
class BIMcollab_IfcFilePINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="SWIGRegisterExceptionCallbacks_BIMcollab_IfcFile", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public static extern void SWIGRegisterExceptionCallbacks_BIMcollab_IfcFile(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_BIMcollab_IfcFile", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public static extern void SWIGRegisterExceptionCallbacksArgument_BIMcollab_IfcFile(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_BIMcollab_IfcFile(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_BIMcollab_IfcFile(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(BIMcollab_IfcFilePINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(BIMcollab_IfcFilePINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="SWIGRegisterStringCallback_BIMcollab_IfcFile", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public static extern void SWIGRegisterStringCallback_BIMcollab_IfcFile(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_BIMcollab_IfcFile(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static BIMcollab_IfcFilePINVOKE() {
  }


  protected class SWIGWStringHelper {

    [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]
	public delegate string SWIGWStringDelegate(global::System.IntPtr message);
    static SWIGWStringDelegate wstringDelegate = new SWIGWStringDelegate(CreateWString);

    [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="SWIGRegisterWStringCallback_BIMcollab_IfcFile", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public static extern void SWIGRegisterWStringCallback_BIMcollab_IfcFile(SWIGWStringDelegate wstringDelegate);

    static string CreateWString([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]global::System.IntPtr cString) {
        //string result = global::System.Runtime.InteropServices.Marshal.PtrToStringUni(cString);
        //return result;
		return global::System.Runtime.InteropServices.Marshal.PtrToStringUni(cString);
    }

    static SWIGWStringHelper() {
      SWIGRegisterWStringCallback_BIMcollab_IfcFile(wstringDelegate);
    }
  }

  static protected SWIGWStringHelper swigWStringHelper = new SWIGWStringHelper();


  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_GetName", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern string BC_IfcFile_GetName(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_SetName", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern void BC_IfcFile_SetName(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]string jarg2);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_GetDate", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern string BC_IfcFile_GetDate(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_SetDate", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern void BC_IfcFile_SetDate(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]string jarg2);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_GetReference", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern string BC_IfcFile_GetReference(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_SetReference", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern void BC_IfcFile_SetReference(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]string jarg2);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_GetProjectIfcGlobalId", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern string BC_IfcFile_GetProjectIfcGlobalId(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_SetProjectIfcGlobalId", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern void BC_IfcFile_SetProjectIfcGlobalId(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]string jarg2);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_GetSpatialStructureElementIfcGlobalId", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern string BC_IfcFile_GetSpatialStructureElementIfcGlobalId(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_SetSpatialStructureElementIfcGlobalId", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern void BC_IfcFile_SetSpatialStructureElementIfcGlobalId(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]string jarg2);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_IsExternal", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern bool BC_IfcFile_IsExternal(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_SetExternal", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern void BC_IfcFile_SetExternal(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_new_BC_IfcFile", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern global::System.IntPtr new_BC_IfcFile();

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_delete_BC_IfcFile", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern void delete_BC_IfcFile(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("BIMcollab_cs", EntryPoint="CSharp_BC_IfcFile_SWIGUpcast", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
  public static extern global::System.IntPtr BC_IfcFile_SWIGUpcast(global::System.IntPtr jarg1);
}
