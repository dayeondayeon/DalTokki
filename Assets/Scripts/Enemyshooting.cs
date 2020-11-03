using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshooting : MonoBehaviour
{
    //적 탄환 생성스크립트
    //enemy bulletshot에서..
    Vector3 in_pos; // bulletspot위치 
    private float time = 0.5f;
    private float timecheck = 0.0f;
    public GameObject mint = null; 
    private int cooltime = 50;
    private int cooltimecheck = 0;
    void Start(){
        in_pos = transform.position;
        //respawnbullet();
    }

    void respawnbullet(){
        for(int i = 0; i<360; i+=13){
            GameObject mints = GameObject.Instantiate(this.mint) as GameObject;
            Destroy(mints,2f);
            mints.transform.position = in_pos;
            mints.transform.rotation =  Quaternion.Euler(0,0,i);
        }
    }
    void Update()
    {
       timecheck += Time.deltaTime;
        if((timecheck>=time)&&(cooltimecheck < cooltime)){
            this.respawnbullet();
            timecheck = 0.0f;
            cooltimecheck++;
        }

        cooltimecheck = 0;
        timecheck = 0.0f;

        
    }

}
