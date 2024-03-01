using UnityEngine;

public class PlayerVariables : MonoBehaviour
{

    public IntVariable life;
    public IntVariable score;
    
    public bool isDash = false;

    public void Start()
    {
        life.Value = 6;
    }
}