using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsSettings : MonoBehaviour
{
    private Collider2D platformCollider;
    private bool isPlayer;

    private void Awake() 
    {
        platformCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        StartCoroutine(AddingTagToPlatforms());

        StartCoroutine(GetDownOfThePlatform());
    }
    private IEnumerator AddingTagToPlatforms()
    {
        if(isPlayer)
        {
            yield return new WaitForSeconds(0.2f);
            this.gameObject.tag = "Ground";
        }
    }

    private IEnumerator GetDownOfThePlatform()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            platformCollider.isTrigger = true;
        }
        if(platformCollider.isTrigger == true)
        {
            yield return new WaitForSeconds(1);
            platformCollider.isTrigger = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isPlayer = true;
        }   
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isPlayer = false;
        }      
    }
}
