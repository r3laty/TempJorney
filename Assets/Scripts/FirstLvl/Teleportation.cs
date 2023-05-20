
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public void Teleport()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
