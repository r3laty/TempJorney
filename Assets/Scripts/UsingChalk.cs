using UnityEngine;

public class UsingChalk : MonoBehaviour
{
    [SerializeField] private Animator _doorAnime;
    [SerializeField] private GameObject _guideText;

    private OpeningCheck openingCheck;
    private bool writing;

    private void Awake() 
    {
        openingCheck = GetComponent<OpeningCheck>();    
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Writing"))
        {
            writing = true;
        }    
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Writing"))
        {
            _guideText.SetActive(false);
            writing = false;
        }    
    }
    private void Update() 
    {
        if(openingCheck.isClaimed && writing)
        {
            _guideText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                _doorAnime.SetBool("isClaimed", true);
            }
        }    
    }
}
