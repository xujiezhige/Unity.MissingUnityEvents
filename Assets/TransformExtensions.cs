//THIS IS AUTO GENERATED CODE, ANY CHANGES WILL BE OVERWRITTEN
using System;
using UnityEngine;

namespace X3 
{
#if ILWeavedEventsOn
	public static class TransformExtensions 
	{
		
		public static void BindSetPositionExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
	        obj.SetPositionExecuting += handler;
	    }
	
		public static void UnBindSetPositionExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
	        obj.SetPositionExecuting -= handler;
	    }
		
		public static void BindSetLocalScaleExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
	        obj.SetLocalScaleExecuting += handler;
	    }
	
		public static void UnBindSetLocalScaleExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
	        obj.SetLocalScaleExecuting -= handler;
	    }
		
		public static void BindSetRotationExecuting(this Transform obj, EventHandler<Quaternion> handler)
	    {
	        obj.SetRotationExecuting += handler;
	    }
	
		public static void UnBindSetRotationExecuting(this Transform obj, EventHandler<Quaternion> handler)
	    {
	        obj.SetRotationExecuting -= handler;
	    }
		
	}

	
#else
	public static class TransformExtensions 
	{
		
		public static void BindSetPositionExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
			Debug.LogWarning("Build symbol ILWeavedEventsOn not specified.");
			
	    }
	
		public static void UnBindSetPositionExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
			Debug.LogWarning("Build symbol ILWeavedEventsOn not specified.");
			
	    }
		
		public static void BindSetLocalScaleExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
			Debug.LogWarning("Build symbol ILWeavedEventsOn not specified.");
			
	    }
	
		public static void UnBindSetLocalScaleExecuting(this Transform obj, EventHandler<Vector3> handler)
	    {
			Debug.LogWarning("Build symbol ILWeavedEventsOn not specified.");
			
	    }
		
		public static void BindSetRotationExecuting(this Transform obj, EventHandler<Quaternion> handler)
	    {
			Debug.LogWarning("Build symbol ILWeavedEventsOn not specified.");
			
	    }
	
		public static void UnBindSetRotationExecuting(this Transform obj, EventHandler<Quaternion> handler)
	    {
			Debug.LogWarning("Build symbol ILWeavedEventsOn not specified.");
			
	    }
		
	}
#endif
}