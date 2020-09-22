using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshooting : MonoBehaviour
{
    //적 탄환 생성
    Vector3 pos;
    Vector3 in_pos; // bulletspot위치 
    private float time = 0.5f;
    private float timecheck = 0.0f;
    public GameObject mint = null; // 총알 에셋
    //public GameObject boss = null;
    void Start(){
        in_pos = transform.position;
        respawnbullet();
    }

    void respawnbullet(){
        GameObject mints = GameObject.Instantiate(this.mint) as GameObject;
        mints.transform.position = in_pos;
       // mints.transform.rotation = transform.rotation;
    }
    void Update()
    {
       // in_pos.x = boss.transform.position.x-2.5f;
       // in_pos.y = boss.transform.position.y -2.0f;
       timecheck += Time.deltaTime;
        if(timecheck>=time){
            this.respawnbullet();
            timecheck = 0.0f;
        }

    }
}
