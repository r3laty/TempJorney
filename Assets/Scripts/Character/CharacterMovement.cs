using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
//This class is in charge of the methods
public class CharacterMovement : MonoBehaviour
{
    [HideInInspector] public bool isGround;

    private Rigidbody2D _playerRb;
    private CharacterController characterController;

    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();
        _playerRb = GetComponent<Rigidbody2D>();    
    }
    public void Move(Vector2 vector, float speed)
    {
        _playerRb.velocity = new Vector2(vector.x * speed * Time.fixedDeltaTime, + _playerRb.velocity.y);
    }
    public void Flip()
    {
        if(characterController.horizontal >= 1)
        {
            transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);
        }
        else if(characterController.horizontal <= -1)
        {
            transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        }
    }

    public void Jump(float jumpForce)
    {
        _playerRb.AddForce(Vector3.up * jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }   
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }        
    }
}
