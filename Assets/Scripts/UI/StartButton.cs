using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
