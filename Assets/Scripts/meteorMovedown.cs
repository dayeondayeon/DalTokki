using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorMovedown : MonoBehaviour
{
    Vector2 pos;
    private float speed = 4.5f;

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
