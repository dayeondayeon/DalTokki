using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshooting : MonoBehaviour
{
    //적 탄환 생성
    Vector3 pos;
    Vector3 in_pos; // bulletspot위치 
    private float time = 1.0f;
    private float timecheck = 0.0f;
    public GameObject mint = null; // 총알 에셋
    public GameObject boss = null;

    /*void Start(){
        in_pos = transform.position;
        respawnbullet();
    }*/

    /*void respawnbullet(){
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

    }*/

    void Update(){
        timecheck += Time.deltaTime;
        if(timecheck>=time){
            shoot();
            timecheck = 0.0f;
        }
       
    }

    void shoot(){
        for(int i = 0; i<360;i+=13){
            GameObject temp = Instantiate(mint);
            Destroy(temp,2f);
            temp.transform.position = boss.transform.position;
            temp.transform.rotation = Quaternion.Euler(0,0,i);
        }
    }
}
