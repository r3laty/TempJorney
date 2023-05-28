using UnityEngine;

public class UsingChalk : MonoBehaviour
{
    [SerializeField] private Animator _doorAnime;
    [SerializeField] private GameObject _guideText;
    [SerializeField] private Collider2D _wallCollider;

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
                _wallCollider.isTrigger = true;
                _doorAnime.SetBool("isClaimed", true);
            }
        }    
    }
}
