using UnityEngine;

public class CharacterAnimatioins : MonoBehaviour
{
    private Animator characterAnime;
    private CharacterController characterController;

    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();    
        characterAnime = GetComponent<Animator>();
    }

    private void Update() 
    {
        if(characterController.horizontal > 0 || characterController.horizontal < 0)
        {
            characterAnime.SetBool("Walk", true);
        }
        else if(characterController.horizontal == 0)
        {
            characterAnime.SetBool("Walk", false);
        }    
    }
}
