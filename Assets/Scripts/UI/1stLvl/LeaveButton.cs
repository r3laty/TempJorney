using UnityEngine.SceneManagement;
using UnityEngine;

public class LeaveButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
