//
// Script name: PathfindingWindow.cs
//
//
// Programmer: Kentaurus
//

#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Pathfinding.Editor
{
	public class PathfindingWindow : EditorWindow
	{
		#region Variables
		#endregion

		#region Unity API
		[MenuItem ("Kentaurus/Pathfinding/Editor")]
		public static void ShowWindow() 
		{
			EditorWindow.GetWindow(typeof(PathfindingWindow));
		}

		protected void OnGUI()
		{

		}
		#endregion

		#region Public Methods
		#endregion

		#region Protected Methods
		#endregion

		#region Private Methods
		#endregion
	}
}
#endif