using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//shooting처럼 적 총알 발사되는 코드 
// 3개의 shooting spot중 가장 좌측
public class shooting_e_spot1 : MonoBehaviour
{
    Vector2 pos;
    float speed = 2;
    void Update()
    {
        pos = transform.position;
        //transform.Rotate(Vector3.forward * speed *100 *Time.deltaTime);
        pos.x -= speed*Time.deltaTime;       
        pos.y -= speed*Time.deltaTime;
        transform.position = pos;
        if(pos.y < -10)
            Destroy(gameObject);
        /*GameObject temp = Instantiate(bullet);
        Destroy(temp, 2f);
        temp.transform.position = transform.position;
        temp.transform.rotation = transform.rotation;*/
    }
}
