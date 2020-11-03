using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //체력+에너지 관련
    [HideInInspector]
    public float startHealth = 3;
    public float health;
    public float energy;
    public float score;
    public bool playerDead;

    public Image healthBar;
    public Text HPText;
    public Image energyBar;
    public Text EnergyText;
    public Text ScoreText;


    // player 이동
    private Touch touch;
    private Transform tran;

    void Start()
    {
        health = startHealth;
        HPText.text = health + "/" + startHealth;
        tran = this.transform;

        energy = 0;
        EnergyText.text = energy.ToString();
        score = 0;
        ScoreText.text = score.ToString();

        playerDead = false;

        InvokeRepeating("chargingEnergy", 1f, 1f);
    }

    public void Damage(int damageAmount) {
        health -= damageAmount;

        if (health < 0) health = 0;
        
        HPText.text = health + "/" + startHealth;
        healthBar.fillAmount = health / startHealth;
    }

    public void getScore(int num) {
        score += num;

        ScoreText.text = score.ToString();
    }

    public void chargingEnergy() //특정 시간마다 에너지가 자동 회복됨
    {
        energy += 2.5f;

        if (energy > 100) energy = 100;

        EnergyText.text = energy.ToString();
        energyBar.fillAmount = energy / 100;
    }

    public void getEnergy(float num) {
        energy += num;

        if (energy > 100) energy = 100;

        EnergyText.text = energy.ToString();
        energyBar.fillAmount = energy / 100;
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

        if (health == 0) {
            playerDead = true;
            Debug.Log("player dead!");
        }

    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("enemy")){
            Destroy(gameObject);
        }
    }
}
