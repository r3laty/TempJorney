using UnityEngine;
[RequireComponent(typeof(CharacterMovement))]
//This class is in charge of the inputs
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    
    [HideInInspector] public float horizontal;

    private CharacterMovement characterMovement;
    
    private void Awake() 
    {
        characterMovement = GetComponent<CharacterMovement>();
    }
    private void FixedUpdate() 
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 movingVector = new Vector2(horizontal, transform.position.y);

        characterMovement.Move(movingVector, _speed);

        characterMovement.Flip();
    }
}
