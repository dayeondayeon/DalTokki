using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Index
    //Main Menu : 0
    //Game : 1
    //나머지는 천천히 생각

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //게임 종료
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
