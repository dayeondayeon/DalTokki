using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_bulletshot : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        Destroy(gameObject,1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime,Space.Self);
    }
}
