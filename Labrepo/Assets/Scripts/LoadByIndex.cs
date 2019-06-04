using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadByIndex : MonoBehaviour
{
    public void LoadByIn(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1f;
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
