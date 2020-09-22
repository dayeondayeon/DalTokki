using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // player 이동
    private Touch touch;
    private Transform tran;
    void Start()
    {
        tran = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
          foreach(Touch touch in Input.touches){
               Vector2 touchPos = new Vector2(touch.position.x, touch.position.y);
                    if(touch.phase == TouchPhase.Moved){
                        //Debug.Log(touchPos);
                       
                        touchPos.x =touchPos.x - (Screen.width/2);
                        touchPos.y = touchPos.y -(Screen.height/2);
                        transform.localPosition = (touchPos);
                       
                    }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("enemy")){
            //Debug.Log("Collision");
           // Vector2 pos = col.gameObject.transform.position;
            Destroy(gameObject);
        }
    }
}
