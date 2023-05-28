using System.Collections;
using UnityEngine;

public class TriggersCheck : MonoBehaviour
{
    [SerializeField] private GameObject _firstText;
    [SerializeField] private GameObject _secondText;
    [SerializeField] private Animator _animeCamera1;
    [SerializeField] private Animator _animeCamera2;
    [SerializeField] private Animator _animeCamera3;
    private bool cutScene;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("First"))
        {
            StartCoroutine(FirstCutScene());
        }
        if(other.CompareTag("Second"))
        {
            StartCoroutine(SecondCutScene());
        }    
        if(other.CompareTag("Third"))
        {
            StartCoroutine(ThirdCutScene());
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("First"))
        {
            _animeCamera1.SetBool("cutscene1", false);
            Destroy(GameObject.FindGameObjectWithTag("First"));
        }
        if(other.CompareTag("Second"))
        {
            _animeCamera2.SetBool("cutscene2", false);
            Destroy(GameObject.FindGameObjectWithTag("Second"));
        }
        if(other.CompareTag("Third"))
        {
            Debug.Log("Third trigger exit");
            _animeCamera3.SetBool("cutscene3", false);
            Destroy(GameObject.FindGameObjectWithTag("Third"));     
        }    

    }

   
   private IEnumerator FirstCutScene()
   {
        _firstText.SetActive(true);
        _animeCamera1.SetBool("cutscene1", true);
        yield return new WaitForSecondsRealtime(1.2f);
        _firstText.SetActive(false);
   }
   private IEnumerator SecondCutScene()
   {
        _secondText.SetActive(true);
        _animeCamera1.SetBool("cutscene2", true);
        yield return new WaitForSecondsRealtime(1.2f);
        _secondText.SetActive(false);
   }
   private IEnumerator ThirdCutScene()
   {
        _animeCamera1.SetBool("cutscene3", true);
        yield return new WaitForSecondsRealtime(0.5f);
   }
}
