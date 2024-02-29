using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points;

    public void Recollect()
    {
        Destroy(gameObject);
    }
}
