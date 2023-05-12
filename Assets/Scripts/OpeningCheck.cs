using System.Collections;
using UnityEngine;
using TMPro;

public class OpeningCheck : MonoBehaviour
{
    [SerializeField] private Animator _chestAnime;
    [SerializeField] private GameObject _chestOpeningGuide;
    [SerializeField] private GameObject _claimedObject; //Text about artifact that we claimed

    [HideInInspector] public bool isClaimed;
    [HideInInspector] public bool keyDown;

    private bool chestCollider;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Chest"))
        {
            _chestOpeningGuide.SetActive(true);
            chestCollider = true;
        }    
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Chest"))
        {
            _chestOpeningGuide.SetActive(false);
        }      
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && chestCollider)
        {
            _chestAnime.SetBool("isOpened", true);
            chestCollider = false;
            keyDown = true;
        }
        if(keyDown)
        {
            StartCoroutine(ClaimedObject());
            isClaimed = true;
            keyDown = false;
        }
    }
    private IEnumerator ClaimedObject()
    {
        _claimedObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2.4f);
        _claimedObject.SetActive(false);
    }
}
