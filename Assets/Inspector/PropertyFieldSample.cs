using UnityEditor;
using UnityEngine;

public class PropertyFieldSample : MonoBehaviour
{
    public int   intValue;
    public float floatValue;
    public bool  boolValue;
    public int[] arrayValue;
}

[CustomEditor(typeof(PropertyFieldSample))]
public class PropertyFieldSampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var propertyFieldSample = target as PropertyFieldSample;

        EditorGUILayout.PropertyField(serializedObject.FindProperty("intValue"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("floatValue"));
        if (GUILayout.Button("Toggle Bool Value"))
        {
            propertyFieldSample.boolValue = !propertyFieldSample.boolValue;
            EditorUtility.SetDirty(target);
        }
        EditorGUILayout.LabelField("Bool Value : " + propertyFieldSample.boolValue);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arrayValue"));
    }
}