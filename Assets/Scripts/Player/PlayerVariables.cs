using UnityEngine;
using Variables;

public class PlayerVariables : MonoBehaviour
{
    public IntVar life;
    public IntVar score;
    
    public bool isDash = false;

    public void Start()
    {
        life.Value = 6;
    }
}