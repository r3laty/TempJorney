using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _missions;

    private bool unpause;

    private void Update()
    {
        if(unpause)
        {
            _pauseMenu.SetActive(false);
            _pauseButton.SetActive(true);
            _missions.SetActive(true);
            Time.timeScale = 1;
            unpause = false;
        }
    }

    public void OnContinueClick()
    {
        unpause = true;
    }
}
