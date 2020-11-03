using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra_bullet_create : MonoBehaviour
{
    Vector3 in_pos;
    Vector3 pos;
    private float time = 2.0f;
    private float timecheck = 0.0f;
    public GameObject bullet = null;
    public GameObject extra = null;
    void Start()
    {
        in_pos = transform.position; //첫 시작 위치(새로운 탄환이 생성될 위치)
        respawnbullet();
    }

    void respawnbullet(){
            GameObject bullets  = GameObject.Instantiate(bullet) as GameObject;
            bullets.transform.position = in_pos;
    }
    // Update is called once per frame
    void Update()
    {
        in_pos.x = extra.transform.position.x;
        in_pos.y = extra.transform.position.y-0.1f;
        timecheck += Time.deltaTime;
        if(timecheck>=time){
            this.respawnbullet();
            timecheck = 0.0f;
        }
    }
}
