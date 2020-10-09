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
        in_pos = transform.position; //첫 시작 위치(새로운 탄환이 생성될 위치)
        respawnbullet();
    }

    void respawnbullet(){
            GameObject pinks  = GameObject.Instantiate(this.pink) as GameObject;
            pinks.transform.position = in_pos;
    }
    // Update is called once per frame
    void Update()
    {
        in_pos.x = player.transform.position.x;
        in_pos.y = player.transform.position.y+0.1f;
        timecheck += Time.deltaTime;
        if(timecheck>=time){
            this.respawnbullet();
            timecheck = 0.0f;
            //Debug.Log("bullet create! " + time + " " + timecheck);
        }
       // Debug.Log("bullet end " + time + " " + timecheck);
    }

    
}
