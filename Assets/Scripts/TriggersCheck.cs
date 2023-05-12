using System.Collections;
using UnityEngine;

public class TriggersCheck : MonoBehaviour
{
    [SerializeField] private GameObject _firstText;
    [SerializeField] private GameObject _secondText;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("First"))
        {
            StartCoroutine(FirstTriggerDelay());
            Destroy(GameObject.FindGameObjectWithTag("First"));
        }
        if(other.CompareTag("Second"))
        {
            StartCoroutine(SecondTriggerDelay());
            Destroy(GameObject.FindGameObjectWithTag("Second"));
        }    
    }

   private IEnumerator FirstTriggerDelay()
   {
        Time.timeScale = 0;
        _firstText.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 1;
        _firstText.SetActive(false);
   }

   private IEnumerator SecondTriggerDelay()
   {
        Time.timeScale = 0;
        _secondText.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 1;
        _secondText.SetActive(false);
   }
}
