using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_down : MonoBehaviour
{
    Vector2 pos;
    float speed = 2f;
    void Start()
    {
        
    }
    void Update()
    {
        pos = transform.position;
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;
        if (pos.y < -10)
        {
            Destroy(gameObject);
            Debug.Log("y축 감소");
        }
    }
}
