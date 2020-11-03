﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    //player탄환 발사 코드
    Vector2 pos;
    float speed = 5;
    Player player;
   // private Script Itemscript;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update(){
        pos = transform.position;
        pos.y += speed*Time.deltaTime;
        transform.position = pos;
        //Itemscript = GameObject.Find("Player").GetComponent<Item>();

        if(pos.y > 6)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("enemy")){
            Destroy(col.gameObject);
            player.getScore(100);
            bool random = (Random.value>0.4f);
            if(random == true)
               GameObject.Find("GameManager").GetComponent<Item>().createItem();
        }
    }
}
