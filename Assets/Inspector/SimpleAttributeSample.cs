using UnityEngine;

public class SimpleAttributeSample : MonoBehaviour
{
    [Multiline]
    public string multiLineValue;

    [TextArea]
    public string textAreaValue;

    [Range(0, 100)]
    public int rangeValueInt;

    [Range(0, 1f)]
    public float rangeValueFloat;

    [Tooltip("Text shown as ToolTip when mouse-over.")]
    public int toolTip;
    
    [Header("Header Text")]
    public bool headerValue;

    [Space(50)]
    public int spaceValue;

    // NOTE:
    // Don't use multi line text like "\n". Such text will be strange cut-out.

    [Header("Multi Header2"), Header("Multi Header1")]
    public bool headerValue2;
}