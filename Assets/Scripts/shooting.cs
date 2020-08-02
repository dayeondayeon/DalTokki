using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
   public GameObject bullet;
   public GameObject parent;


   void Start()
   {
       GameObject.Instantiate<GameObject>(bullet, parent.x,parent.y,parent.z,Quaternion.identity);
   }
   void Update(){
       bullet.Transform(parent.x, parent.y*2f,parent.z);
   }
}