using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public void MoveTo1Stage() {
        SceneManager.LoadScene("extra_battle");
    }
    public void MoveTo2Stage()
    {
        SceneManager.LoadScene("boss_battle");
    }
}
