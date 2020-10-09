using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Player player;

    public GameObject GameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.playerDead) {
            GameOver();
        }
    }

    private void GameOver() {
        GameOverUI.SetActive(true);
        Debug.Log("GameOver");
        Time.timeScale = 0f;
    }
}
