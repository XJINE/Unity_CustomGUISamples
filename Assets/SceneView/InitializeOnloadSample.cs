// NOTE:
// Using InitializeOnload is not good in most case.
// Because it can't remove (or control) the EventHandler.
// You can use it if the Custom-GUI needs to keep working.
// Unfortunately, some blogs are suggesting to using InitializeOnload.
// As a side note, there are similar methods InitializeOnLoadMethod and RuntimeInitializeOnLoadMethod.

// #if UNITY_EDITOR
// using UnityEditor;
// using UnityEngine;
//
// [InitializeOnLoad]
// public class InitializeOnloadSample
// {
//     static InitializeOnloadSample()
//     {
//         SceneView.duringSceneGui += (sceneView =>
//         {
//             Handles.BeginGUI();
//
//             if (GUILayout.Button("Button in SceneView"))
//             {
//                 Debug.Log(typeof(InitializeOnloadSample));
//             }
//
//             Handles.EndGUI();
//         });
//     }
// }
// #endif