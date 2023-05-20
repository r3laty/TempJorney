using UnityEngine.UI;
using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private AudioSource _bgMusic;
    private void Update()
    {
        _bgMusic.volume = _musicVolumeSlider.value;
    }
}
