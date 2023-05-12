using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class SoundsControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Music_textMeshPro;
    [SerializeField] private Slider Music_slider;

    [SerializeField] private TextMeshProUGUI Sounds_textMeshPro;
    [SerializeField] private Slider Sounds_slider;
    private void Start()
    {
        Music_textMeshPro.text = (Music_slider.value * 100).ToString();
        Sounds_textMeshPro.text = (Sounds_slider.value * 100).ToString();
    }
    private void Update() 
    {
        OnMusicSliderValueChanged();

        OnSoundSliderValueChanged();    
    }
    private void OnMusicSliderValueChanged()
    {
        Music_textMeshPro.text = Mathf.Round(Music_slider.value * 100).ToString();
    }

    private void OnSoundSliderValueChanged()
    {
        Sounds_textMeshPro.text = Mathf.Round(Sounds_slider.value * 100).ToString();
    } 
}
