using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_bulletshot : MonoBehaviour
{
    public float speed = 5f;
    private Player player;

    void Start()
    {
        Destroy(gameObject,3f);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent <Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime,Space.Self);
    }

    void OnCollisionEnter2D(Collision2D col){
       if(col.gameObject.CompareTag("Player")){
           player.Damage(1);
           Debug.Log("Damaged");
       }
   }
}
