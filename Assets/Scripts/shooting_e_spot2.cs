using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting_e_spot2 : MonoBehaviour
{
    
    Vector2 pos;
    float speed = 2;
    void Update()
    {
        pos = transform.position;
        //transform.Rotate(Vector3.forward * speed *100 *Time.deltaTime);
        pos.x += speed*Time.deltaTime;       
        pos.y += speed*Time.deltaTime;
        transform.position = pos;
        if(pos.y < -10)
            Destroy(gameObject);
        
    }
}
