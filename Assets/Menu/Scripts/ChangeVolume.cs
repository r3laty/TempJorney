using UnityEngine.UI;
using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private Slider _soundsVolumeSlider;
    [SerializeField] private AudioSource _bgMusic;
    [SerializeField] private AudioSource _buttonClickSound;
    private void Update()
    {
        _bgMusic.volume = _musicVolumeSlider.value;
        _buttonClickSound.volume = _soundsVolumeSlider.value;
    }
}
