using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
   public GameObject bullet = null;
   Vector3 parent = GameObject.Find("Player").transform.position;
   //new Vector3 temp = (parent.position.x, parent.position.y, parent.position.z);
   Vector3 pos;
   void Shootings()
   {
       GameObject bulls = GameObject.Instantiate(this.bullet) as GameObject;
       pos = GameObject.Find("pink").transform.position;
       pos.x = parent.x;
       pos.y = parent.y*2;
       pos.z = parent.z;
       //Instantiate(bullet, parent.position,Quaternion.identity);
   }
   void Update(){
     //  bullet.position = transform(temp.x, temp.y*2, temp.z);
   }
}
