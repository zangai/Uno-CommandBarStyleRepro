package md5ac42cfaecf52754b16970614ee850404;


public class MainPage
	extends md53236df40a47f0df12473f710f43d224f.Page
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CommandBarStyleRepro.MainPage, CommandBarStyleRepro.Droid", MainPage.class, __md_methods);
	}


	public MainPage (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MainPage.class)
			mono.android.TypeManager.Activate ("CommandBarStyleRepro.MainPage, CommandBarStyleRepro.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
