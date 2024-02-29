using System;
using Unity.VisualScripting;
using UnityEngine;

public class UITest : MonoBehaviour
{
    public LifeController LifeController;
    public PointsController PointsController;
    public PlayerVariables Variables;

    private void OnEnable()
    {
        Variables.OnLifeChange += ChangeLifeController;
    }

    private void ChangeLifeController(int life)
    {
        if (life <= 0)
        {
            Debug .Log("Perdiste");
        }
        LifeController.UpdateLife(life);
    }

    private void OnDisable()
    {
        Variables.OnLifeChange -= ChangeLifeController;
    }
}
