#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class SceneViewSample : EditorWindow
{
    private static bool _visible = false;
    
    [MenuItem("Custom/SceneViewSample")]
    private static void ToggleVisibility()
    {
        if (_visible)
        {
            SceneView.duringSceneGui -= OnSceneGUI;
        }
        else
        {
            SceneView.duringSceneGui += OnSceneGUI;
        }

        _visible = !_visible;
    }

    private static void OnSceneGUI(SceneView sceneView)
    {
        Handles.BeginGUI();

         if (GUILayout.Button("Button in SceneView"))
         {
             Debug.Log(typeof(SceneViewSample));
         }

        Handles.EndGUI();
    }
}
#endif