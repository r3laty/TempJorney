using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
//This class is in charge of the methods
public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private CharacterController characterController;

    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();
        playerRB = GetComponent<Rigidbody2D>();    
    }
    public void Move(Vector2 vector, float speed)
    {
        playerRB.velocity = new Vector2(vector.x * speed * Time.fixedDeltaTime, + playerRB.velocity.y);
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
}
