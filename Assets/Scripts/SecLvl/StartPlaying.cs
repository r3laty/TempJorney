using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlaying : MonoBehaviour
{
    [SerializeField] private GameObject _firstMonologueText;
    [SerializeField] private Camera _mainCamera;
    void Start()
    {
        Time.timeScale = 0;
        _firstMonologueText.SetActive(true);
    }
    void Update()
    {
        StartCoroutine(Wait());
    }
    
    private IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
        _firstMonologueText.SetActive(false);
        _mainCamera.orthographicSize = 7.75f;
        _mainCamera.transform.position = new Vector3(-3.72f, -1.59f, -10);
    }
}
