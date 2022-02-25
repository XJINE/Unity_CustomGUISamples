using UnityEngine;

public class OnValidateAndProperty : MonoBehaviour
{
    // field:SerializeField enable to show the property in Inspector.

    [field:SerializeField]
    public int PropertyA { get; private set; }

    // This is ignored in Inspector.
    // CS0657: 'field' is not a valid attribute location for this declaration.

    private int _propertyB;
    [field:SerializeField]
    public int PropertyB
    {
                get => _propertyB;
        private set => _propertyB = ValidateValue(value);
    }

    // This looks good, but couldn't validate.
    // So use "OnValidate".

    [SerializeField]
    private int _propertyC;
    public  int PropertyC => _propertyC;

    public int ValidateValue(int value)
    {
        return value + 1;
    }

    // OnValidate called when some values in Inspector are updated.

    private void OnValidate()
    {
        _propertyC = ValidateValue(_propertyC);
    }
}