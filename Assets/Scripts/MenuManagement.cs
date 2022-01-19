using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{

    public Canvas canvas;
    public bool gameIsStarted;
    void Start() 
    {
        canvas = this.gameObject.GetComponent<Canvas>();
        gameIsStarted = false;
    }

    public void ChangeSceneToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChangeSceneToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartGame()
    {
        gameIsStarted = true;
        canvas.enabled = false; 
    }
}
