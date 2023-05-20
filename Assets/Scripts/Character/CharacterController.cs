using UnityEngine;
[RequireComponent(typeof(CharacterMovement))]
//This class is in charge of the inputs
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float _speed = 200;
    [SerializeField] private float _jumpForce = 50;
    
    [HideInInspector] public float horizontal;

    private CharacterMovement characterMovement;
    private bool wasPress;
    
    private void Awake() 
    {
        characterMovement = GetComponent<CharacterMovement>();
        Time.timeScale = 1;
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            wasPress = true;
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            wasPress = false;
        }
    }
    private void FixedUpdate() 
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 movingVector = new Vector2(horizontal, transform.position.y);

        characterMovement.Move(movingVector, _speed);

        characterMovement.Flip();

        if(wasPress && characterMovement.isGround)
        {
            characterMovement.Jump(_jumpForce);
        }
    }
}
