using System.Collections;
using UnityEngine;
using TMPro;

public class ToDoList : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _firstThingText;
    [SerializeField] private TextMeshProUGUI _secondThingText;
    [SerializeField] private TextMeshProUGUI _thirdThingText;

    private OpeningCheck openingCheck;

    private void Awake() 
    {
        openingCheck = GetComponent<OpeningCheck>();
    }

    private void Update() 
    {
        if(openingCheck.isClaimed)
        {
            _secondThingText.fontStyle = FontStyles.Strikethrough;
            _thirdThingText.gameObject.SetActive(true);
        }  
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("First"))
        {
            StartCoroutine(OnFirstTriggerText());
        }
        if(other.CompareTag("Second"))
        {
            StartCoroutine(OnSecondTriggerText());
        }    
    }

    private IEnumerator OnFirstTriggerText()
    {
        yield return new WaitForSecondsRealtime(2f);
        _firstThingText.gameObject.SetActive(true); 
    }

    private IEnumerator OnSecondTriggerText()
    {
        yield return new WaitForSecondsRealtime(2f);
        _firstThingText.fontStyle = FontStyles.Strikethrough;
        _secondThingText.gameObject.SetActive(true);
    }
}
