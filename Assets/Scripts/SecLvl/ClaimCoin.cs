using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaimCoin : MonoBehaviour
{
    [SerializeField] private GameObject _coin1;
    [SerializeField] private TextMeshProUGUI _coinsCount;
    [SerializeField] private Animator _coinAnime;

    private string textPattern = "количество монет: ";
    private bool claim;

    private void Update() 
    {
        ChangeTextWhenYouClaimACoin();    
    }

    private void ChangeTextWhenYouClaimACoin()
    {
        if(claim)
        {
            _coinsCount.text = textPattern + 1.ToString();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Coin"))
        {
            _coinAnime.SetBool("ClaimCoin", true);
            claim = true;
        }   
    }

}
