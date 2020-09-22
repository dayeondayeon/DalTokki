using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra_move : MonoBehaviour
{
   // extra몬스터 하강 
   Vector2 pos;
   private float speed = 2.0f; //하강속도

  
    void Update()
    {
        pos = transform.position;
        pos.y -= speed*Time.deltaTime;
        transform.position = pos;
        if(pos.y<-8){
            Destroy(gameObject);
        }
    }

    
}
