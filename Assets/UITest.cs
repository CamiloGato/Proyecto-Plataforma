using System;
using Unity.VisualScripting;
using UnityEngine;

public class UITest : MonoBehaviour
{
    private LifeController _lifeController;
    private PlayerVariables _variables;

    public void Initialize( LifeController lifeController, PlayerVariables variables )
    {
        _lifeController = lifeController;
        _variables = variables;
    }
    
    public void Subscribe()
    {
        _variables.life.OnValueChange += ChangeLifeController;
    }

    public void UnSubscribe()
    {
        _variables.life.OnValueChange -= ChangeLifeController;
    }

    public void Disable()
    {
        
    }

    private void ChangeLifeController(int life)
    {
        if (life <= 0)
        {
            Debug .Log("lose");
        }
        _lifeController.UpdateLife(life);
    }
}
