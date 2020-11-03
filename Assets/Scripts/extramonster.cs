using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extramonster : MonoBehaviour
{
    //엑스트라 몬스터 respawn
    public GameObject extra = null;
    public GameObject Parent;

    private int respawnnum = 50; //엑스트라 몬스터 개수 
    Vector3 ran_pos;
    private float time = 3.0f;
    private float timecheck = 0.0f;

    // Update is called once per frame
    void Update()
    {   
        timecheck += Time.deltaTime;
        if((timecheck >= time)&&(respawnnum > 0)){
            ran_pos.x = Random.Range(-2.2f,2.2f);
            ran_pos.y = Random.Range(5.6f,6.2f);
            ran_pos.z = 0f;
            /*
            Instantiate(extra);
            */
            GameObject newObj = GameObject.Instantiate(extra) as GameObject;
            Debug.Log("newObj: " + newObj.transform.localPosition);
            newObj.transform.parent = Parent.transform;

            //extra.transform.position = ran_pos;
            newObj.transform.position = ran_pos;

            timecheck = 0.0f;
            respawnnum--;
        }
    }


}
