using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultimateshot : MonoBehaviour
{
    public GameObject pinkbullet;
    public GameObject pinkhierarchybullet;
    public GameObject ultimatebullet;
    public GameObject button;
    Player player;
    Vector2 pos;
    private float speed = 3.0f;
    


    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    public void setActiveOrNot()
    {
        Debug.Log("SetActive함수");
        if(checkMPMax() == true){
            pinkbullet.SetActive(false);
            pinkhierarchybullet.SetActive(false);
            shot();
            pinkbullet.SetActive(true);
            pinkhierarchybullet.SetActive(true);
        }
    }

    bool checkMPMax(){
        if(player.energy == 100)
            return true;
        else
            return false; 
    }

    void shot(){
        Instantiate(ultimatebullet);
        pos.x = player.transform.position.x;
        pos.y = player.transform.position.y + speed*Time.deltaTime;
        ultimatebullet.transform.position = pos;

        if(pos.y > 10){
            Destroy(ultimatebullet);
        }
    }
}

