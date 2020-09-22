using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
  //player탄환 발사 코드
  Vector2 pos;
  float speed = 5;
  void Update(){
    pos = transform.position;
    pos.y += speed*Time.deltaTime;
    transform.position = pos;
    if(pos.y > 6)
    {
      Destroy(gameObject);
    }
  }

  void OnCollisionEnter2D(Collision2D col){
      if(col.gameObject.CompareTag("enemy")){
        Destroy(col.gameObject);
      }
  }
}
