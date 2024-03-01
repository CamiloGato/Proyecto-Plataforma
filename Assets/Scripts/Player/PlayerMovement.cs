using System.Collections;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public float jumpForce;
    public float velocity;
    public float distanceToFloor = 0.8f;
    public LayerMask ground;

    private Rigidbody2D rb;
    private PlayerVariables playerVariables;
    private int horizontal;
    private bool canJump = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerVariables = GetComponent<PlayerVariables>();
    }

    private void Update()
    {
        horizontal = (int) Input.GetAxisRaw(horizontalAxis);

        if ( Input.GetKeyDown(KeyCode.W) && canJump )
        {
            StartCoroutine(jump());
        }
       
    }

    private void FixedUpdate()
    {
        float prevVerticalVelocity = rb.velocity.y;
        if ( horizontal != 0 && !playerVariables.isDash )
        {
            rb.velocity = new Vector2( horizontal, prevVerticalVelocity);
        }
    }
    
    IEnumerator jump()
    {
        print("Inicio la corrutina");
        canJump = false;
        Vector2 jumpForceVector = Vector2.up * jumpForce;
        rb.AddForce(jumpForceVector);
        yield return new WaitUntil(
            () =>
            {
                Vector2 origen = rb.position;
                return Physics2D.Raycast(origen, Vector2.down, distanceToFloor, ground);
            }    
            
        );

        // TODO: Ma�ana particula :D

        yield return new WaitForSeconds( 1f );
        canJump = true;
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, Vector2.down * distanceToFloor, Color.red);
    }

}
