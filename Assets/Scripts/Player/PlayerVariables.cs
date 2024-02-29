using System;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{


    public event Action<int> OnLifeChange;
    private int _life = 3;
    public int Life
    {
        get => _life;
        set
        {
            _life = value;
            //Operador ternario
            OnLifeChange?.Invoke(value);
        }
    }
    
    public int points = 0;
    
    
    public bool isDash = false;

    private void Start()
    {
        Life = 5;
    }
}