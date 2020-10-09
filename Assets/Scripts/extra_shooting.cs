using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class extra_shooting : MonoBehaviour {
    Vector2 pos;
    float speed = 5;

    private Player player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent <Player>();
    }

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
            player.Damage(1);
            Debug.Log("Damaged!");

            if (player.health == 0) {
                Debug.Log("Destroyed");
                Destroy(col.gameObject);
            }                    
        }
    }
}
