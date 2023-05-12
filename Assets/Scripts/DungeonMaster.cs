using UnityEngine;


public class DungeonMaster : MonoBehaviour
{
    [SerializeField] private GameObject _tpText;
    [SerializeField] private Animator _tpAnime;

    private bool come;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Teleporter"))
        {
            _tpText.SetActive(true);
            come = true;
        }   
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E) && come)
        {
            _tpAnime.SetBool("Teleport", true);
        }    
    }
}
