#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class CustomEditorSample : MonoBehaviour
{
    public int   intValue;
    public float floatValue;
}

#if UNITY_EDITOR

[CustomEditor(typeof(CustomEditorSample)), CanEditMultipleObjects]
public class CustomEditorSampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var customEditorSample = (CustomEditorSample)target;

        if (GUILayout.Button("Ex: Just add a button."))
        {
            // NOTE:
            // SetDirty is strong important to notify scene that the values are changed.

            customEditorSample.intValue   += 1;
            customEditorSample.floatValue -= 1;
            EditorUtility.SetDirty(target);
        }

        base.OnInspectorGUI(); // Show Default GUI.
    }
}

// [CustomEditor(typeof(CustomEditorSample)), CanEditMultipleObjects]
// public class CustomEditorSampleEditor2 : Editor
// {
//     public override void OnInspectorGUI()
//     {
//         GUILayout.Label("Should be Inheritance. Only one of the Editor is valid.");
//     }
// }

#endif