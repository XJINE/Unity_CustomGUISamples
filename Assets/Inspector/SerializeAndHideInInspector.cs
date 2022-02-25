using System;
using UnityEngine;

public class SerializeAndHideInInspector : MonoBehaviour
{
    // NOTE:
    // These are used to control serialization or accessibility.
    // If you want to serialize but need to hide in Inspector, use "HideInInspector".
    // If you want to encapsulation field but need to show in Inspector, use "SerializeField".
    // If you want to make non serialized public field, use "NonSerialized".
    // Such field will hide in Inspector.

    [HideInInspector] public bool hideInInspectorField;

    [SerializeField] private bool serializedPrivateField;

    [NonSerialized] public bool nonSerializedPublicField;
}