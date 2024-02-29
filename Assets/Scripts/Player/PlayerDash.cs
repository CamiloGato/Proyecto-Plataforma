using System;
using System.Collections;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{

    public float dashSpeed;

    private Rigidbody2D rb;
    private PlayerVariables playerVariables;
    private Collider2D collider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        playerVariables = GetComponent<PlayerVariables>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.H) && !playerVariables.isDash)
        {
            StartCoroutine(Dash());
        }
    }

    private IEnumerator Dash()
    {
        playerVariables.isDash = true;

        Vector2 currentVelocity = rb.velocity;
        currentVelocity = currentVelocity.normalized * dashSpeed;
        rb.velocity = currentVelocity;

        yield return new WaitUntil(
            () =>
            {
                return transform.position.x >= 2;
            }
        );

        // ejecuten particulas

        yield return new WaitForSeconds(0.5f);

        playerVariables.isDash = false;
    }
}
