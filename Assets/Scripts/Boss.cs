using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    [HideInInspector]
    public float bossHP;
    public float startHP = 100f;

    public Image BossHPBar;
    
    public void Start()
    {
        bossHP = startHP;
    }

    public void Update()
    {
        
    }

    public void BossDamage(float damageMount) {
        Debug.Log("boss damaged!");
        bossHP -= damageMount;
        if (bossHP < 0) bossHP = damageMount;
        BossHPBar.fillAmount = bossHP / startHP;
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("PlayerBullet")){
            BossDamage(1.5f);
        }
    }
}
