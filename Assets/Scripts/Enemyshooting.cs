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
    private float rot_speed = 5f;
    public GameObject mint = null; 
    private int cooltime = 50; //50번까지 탄막쏘기 가능
    private int circle_cooltimecheck = 0;
    private int rotate_cooltimecheck = 0;
    void Start(){
        in_pos = transform.position;
    }
    void circleshot(){
        for(int i = 0; i<360; i+=13){
            GameObject mints = GameObject.Instantiate(this.mint) as GameObject;
            Destroy(mints,2f);
            mints.transform.position = in_pos;
            mints.transform.rotation =  Quaternion.Euler(0,0,i);
        }
    }

    void rotateshot(){
        transform.Rotate(Vector3.forward * rot_speed*100*Time.deltaTime);
        GameObject mints = GameObject.Instantiate(this.mint) as GameObject;
        Destroy(mints,2f);
        mints.transform.position = in_pos;
        mints.transform.rotation = transform.rotation;
    }

    void Update()
    {
       timecheck += Time.deltaTime;
        if((timecheck>=time)&&(circle_cooltimecheck < cooltime)){
            this.circleshot();
            timecheck = 0.0f;
            circle_cooltimecheck++;
        }

        if(circle_cooltimecheck >= cooltime){
            this.rotateshot();
            timecheck = 0.0f;
            rotate_cooltimecheck++;
        }
    }
//&&(rotate_cooltimecheck < cooltime)
}
