package md58acb6d3b5b4a53346a0310ad4c6aae2e;


public class MapView
	extends android.opengl.GLSurfaceView
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Nutiteq.Ui.MapView, NutiteqMapsSDK.Android, Version=1.0.5959.32842, Culture=neutral, PublicKeyToken=null", MapView.class, __md_methods);
	}


	public MapView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MapView.class)
			mono.android.TypeManager.Activate ("Nutiteq.Ui.MapView, NutiteqMapsSDK.Android, Version=1.0.5959.32842, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public MapView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MapView.class)
			mono.android.TypeManager.Activate ("Nutiteq.Ui.MapView, NutiteqMapsSDK.Android, Version=1.0.5959.32842, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

	java.util.ArrayList refList;
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
