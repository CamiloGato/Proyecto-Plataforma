using System;
using UnityEngine;

namespace Variables
{
    public abstract class BaseVar<T> : ScriptableObject
    {
        public event Action<T> OnValueChange;
        [SerializeField] protected T _value;
        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                OnValueChange?.Invoke(value);
            }
        }
    }
}