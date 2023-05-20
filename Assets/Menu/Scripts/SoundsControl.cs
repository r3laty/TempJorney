using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class SoundsControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Music_textMeshPro;
    [SerializeField] private Slider Music_slider;
    private void Start()
    {
        Music_textMeshPro.text = (Music_slider.value * 100).ToString();
    }
    private void Update() 
    {
        OnMusicSliderValueChanged();   
    }
    private void OnMusicSliderValueChanged()
    {
        Music_textMeshPro.text = Mathf.Round(Music_slider.value * 100).ToString();
    }
}
