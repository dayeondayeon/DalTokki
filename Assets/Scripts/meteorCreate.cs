using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorCreate : MonoBehaviour
{
    Vector2 pos;
    public GameObject meteor = null;
    private float time = 5.0f;
    private float timecheck = 0.0f;
    void Update()
    {
        timecheck += Time.deltaTime;
        if(timecheck >= time){
            pos.x = Random.Range(-2.2f,2.2f);
            pos.y = Random.Range(5.6f,6.2f);
            Instantiate(meteor);
            meteor.transform.position = pos;
            timecheck = 0.0f;
        }
    }
    
}