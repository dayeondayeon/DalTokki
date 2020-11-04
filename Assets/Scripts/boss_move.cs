using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_move : MonoBehaviour
{
    float rightMax = 2.0f;
    float leftMax = -2.0f;
    float currentPositionx;
    float currentPositiony;
    float direction = 3.0f;

    void Start(){
        currentPositionx = transform.position.x;
        currentPositiony = transform.position.y;
    }
    void Update()
    {
       currentPositionx += Time.deltaTime*direction;
       if(currentPositionx >= rightMax){
           direction *= -1;
           currentPositionx = rightMax;
       }
       else if(currentPositionx <= leftMax){
           direction *= -1;
           currentPositionx = leftMax;
       }
       transform.position = new Vector2(currentPositionx,currentPositiony);
    }
}
