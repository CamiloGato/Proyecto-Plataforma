using System;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{

    public IntVariable life;
    public IntVariable score;
    
    public bool isDash = false;

    public void Initialize()
    {
        life = new IntVariable(5);
        score = new IntVariable(4);
    }

    public void SetUp()
    {
        life.Value = 6;
    }
}

[Serializable]
public class IntVariable
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
    
    public IntVariable(int defaultValue)
    {
        Value = defaultValue;
    }
    
}