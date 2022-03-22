using UnityEditor;
using UnityEngine;

public class OnSceneGUISample : MonoBehaviour
{
    public Vector3 origin = Vector3.zero;
}

[CustomEditor(typeof(OnSceneGUISample)), CanEditMultipleObjects]
public class OnSceneGUISampleEditor : Editor
{
    // NOTE:
    // OnSceneGUI works when the component(object) is selected.
    // It's like a OnDrawGizmosSelected.

    private void OnSceneGUI()
    {
        var onSceneGUISample = target as OnSceneGUISample;
        Handles.DrawLine(onSceneGUISample.origin, onSceneGUISample.transform.position, 2);
    }
}