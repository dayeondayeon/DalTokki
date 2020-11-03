using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Player player;
    public GameObject juice = null;
    public GameObject cookie = null;
    GameObject temp;
    Vector2 temp_pos;
    Vector2 pos;
    float speed = 2;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;
        if (pos.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            player.getEnergy(10);
            Destroy(gameObject);
        }
    }

    public void createItem(){
        bool random = (Random.value>0.5f);
        Debug.Log("item created!");
        if(random == true){
            temp = GameObject.Instantiate(this.juice) as GameObject;
            transferItem();
        }
       else{
           temp = GameObject.Instantiate(this.cookie) as GameObject;
           transferItem();
       }

    }

    void transferItem() {
        temp_pos = player.transform.position;
        temp_pos.y += 10;
        temp.transform.position = temp_pos;
    }

}
