using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra_shooting : MonoBehaviour
{
    Vector2 pos;
    float speed = 5;
    void Update()
    {
        pos = transform.position;
        pos.y -= speed*Time.deltaTime;
        transform.position = pos;
        if(pos.y<-10){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Player")){
            Destroy(col.gameObject);
        }
    }
}
