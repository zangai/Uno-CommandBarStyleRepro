package md5bf4da100b2dbb022d895d9bb2c38dfa6;


public class NativeApplication
	extends android.app.Application
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:()V:GetOnCreateHandler\n" +
			"n_GetTypeAssemblyFullName:(Ljava/lang/String;)Ljava/lang/String;:__export__\n" +
			"";
	}

	public NativeApplication ()
	{
		mono.MonoPackageManager.setContext (this);
	}


	public void onCreate ()
	{
		n_onCreate ();
	}

	private native void n_onCreate ();


	public static java.lang.String GetTypeAssemblyFullName (java.lang.String p0)
	{
		return n_GetTypeAssemblyFullName (p0);
	}

	private static native java.lang.String n_GetTypeAssemblyFullName (java.lang.String p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
