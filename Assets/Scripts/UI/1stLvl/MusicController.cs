using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource _mainMusic;
    [SerializeField] private Slider _musicVolumeSider;
    private void Update()
    {
        _mainMusic.volume = _musicVolumeSider.value;
    }
}
