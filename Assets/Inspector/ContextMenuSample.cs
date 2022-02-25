using UnityEngine;

public class ContextMenuSample : MonoBehaviour
{
    [ContextMenuItem("Context Menu Item Name", "SampleMethod")]
    public int contextMenuItem;

    [ContextMenuItem("Context Menu Item Name", "SampleMethod"), SerializeField]
    protected int contextMenuItemProtected;

    // NOTE:
    // https://forum.unity.com/threads/contextmenuitem-on-array-field-add-command-to-the-element-but-not-the-property-itself.1216731/
    // ContextMenuItem attribute set into array or list works wrong now.

    [ContextMenuItem("Context Menu Item Name", "SampleMethod")]
    public int[] contextMenuItemArray;

    [ContextMenu("Context Menu Name")]
    private void SampleMethod()
    {
        Debug.Log("Sample Method");
    }
}