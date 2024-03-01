using System;
using UnityEngine;

public class IntVariable : MonoBehaviour
{
    public event Action<int> OnValueChange;
    [SerializeField] private int _value;
    public int Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChange?.Invoke(value);
        }
    }
    
}