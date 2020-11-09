using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateBulletCreate : MonoBehaviour
{
    public GameObject ultimatebullet;
    Player player;
    Vector2 pos;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        pos = player.transform.position;
    }

    void Update()
    {
        ultimatebullet.transform.position = pos;
        if(checkMPMax() == true){
            respawnbullet();
            player.initializeEnergy();
        }
    }

    bool checkMPMax(){
            if(player.energy == 100)
                return true;
            else
                return false; 
    }

    void respawnbullet(){
        Instantiate(ultimatebullet);
        ultimatebullet.transform.position = pos;
    }
}
