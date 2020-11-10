using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultimateshot : MonoBehaviour
{
    Player player;
    Boss boss;
    Vector2 pos;
    private float speed = 5.0f;
    
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        pos = player.transform.position;
    }

    void Update()
    {
        pos.y += speed*Time.deltaTime;
        transform.position = pos; 
        if (pos.y > 10){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("Enemy")){
            Destroy(col.gameObject);
            player.getScore(200);
        }
        if (col.gameObject.CompareTag("Boss")){
            boss.BossDamage(10);
        }
    }
}

