using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
           foreach(Touch touch in Input.touches){
               Vector2 touchPos = new Vector2(touch.position.x, touch.position.y);
                    if(touch.phase == TouchPhase.Moved){
                        //Debug.Log(touchPos);
                        //transform.position = touchPos;
                        touchPos.x = touchPos.x/180;
                        touchPos.y = touchPos.y/180;
                        transform.position = (touchPos);
                    }
            }
        }
    }
}
