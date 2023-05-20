using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _missions;

    private bool pause;
    
    private void Update()
    {
        if(pause)
        {
            _pauseMenu.SetActive(true);
            _pauseButton.SetActive(false);
            _missions.SetActive(false);
            Time.timeScale = 0;
            pause = false;
        }
    }
    public void OnPauseClick()
    {
        pause = true;
    }
}
