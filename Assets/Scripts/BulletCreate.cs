using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 in_pos;
    Vector3 pos;
    private float time = 1.0f;
    private float timecheck = 0.0f;
    public GameObject pink = null;
    public GameObject player = null;
    void Start()
    {
        in_pos = transform.position;
    }

    void respawnbullet(){
            GameObject pinks  = GameObject.Instantiate(this.pink) as GameObject;
            pinks.transform.position = in_pos;
            /*pos = in_pos;
            pos.y += speed*Time.deltaTime;
            pinks.transform.position = pos;
            if(pos.y>13){
                Destroy(pinks);
            }*/
    }

    // Update is called once per frame
    void Update()
    {
        in_pos.x = player.transform.position.x;
        in_pos.y = player.transform.position.y+0.5f;
        timecheck += Time.deltaTime;
        if(timecheck>time){
            timecheck = 0.0f;
            this.respawnbullet();
            Debug.Log("bullet create! " + time + " " + timecheck);
        }
        Debug.Log("bullet end " + time + " " + timecheck);
    }

    
}
