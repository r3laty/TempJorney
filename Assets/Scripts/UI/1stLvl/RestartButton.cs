using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
  public void OnClick()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Time.timeScale = 1;
  } 
}
