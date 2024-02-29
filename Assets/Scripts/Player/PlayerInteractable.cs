using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    private PlayerVariables playerVariables;

    private void Awake()
    {
        playerVariables = GetComponent<PlayerVariables>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Coin>(out Coin coin))
        {
            coin.Recollect();
            playerVariables.points++;
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            playerVariables.Life--;
        }
    }
}
