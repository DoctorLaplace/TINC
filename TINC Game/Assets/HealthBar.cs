using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour{
    public Transform bar;

    public GameObject player;

    // Start is called before the first frame update
    void Start(){
        bar = transform.Find("Bar");
    }


    public void Update() {
        bar.localScale = new Vector3(player.GetComponent<Entity>().health / 100, 1f);
        if (player.GetComponent<Entity>().health / 100 > .60f){
            bar.gameObject.SetActive(true);
            bar.Find("BarSpirte").GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (player.GetComponent<Entity>().health /100 < 0.60f){
            bar.Find("BarSpirte").GetComponent<SpriteRenderer>().color = Color.yellow;
        }

        if (player.GetComponent<Entity>().health / 100 < 0.30f){
           bar.Find("BarSpirte").GetComponent<SpriteRenderer>().color = Color.red;
            
        }
        if((player.GetComponent<Entity>().health / 100) <= 0.0f)
        {
            bar.gameObject.SetActive(false);    
        }
    }
}
