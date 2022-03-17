using UnityEngine;

public enum InspectorNameSampleEnum
{
    Auto   = 0,
    [InspectorName("16 bits")]
    UInt16 = 1,
    [InspectorName("32 bits")]
    UInt32 = 2,
}

public class InspectorNameSample : MonoBehaviour
{
    public InspectorNameSampleEnum sampleEnum;
}
