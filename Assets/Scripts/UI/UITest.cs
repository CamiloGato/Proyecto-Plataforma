using UnityEngine;

public class UITest : MonoBehaviour
{
    public LifeController lifeController;
    public IntVariable life;
    public IntVariable score;
    
    public void OnEnable()
    {
        life.OnValueChange += ChangeLifeController;
    }

    public void OnDisable()
    {
        life.OnValueChange -= ChangeLifeController;
    }

    private void ChangeLifeController(int life)
    {
        if (life <= 0)
        {
            Debug .Log("lose");
        }
        lifeController.UpdateLife(life);
    }
}
