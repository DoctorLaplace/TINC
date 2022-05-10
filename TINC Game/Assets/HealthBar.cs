using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour{
    public Slider slide;
    public GameObject player;
    public Gradient gradient;
    public Image fill;

    // Start is called before the first frame update
    void Start(){
        slide.value = player.GetComponent<Entity>().health;
        fill.color = gradient.Evaluate(slide.normalizedValue);
    }

    public void setHealth(){
       slide.value = player.GetComponent<Entity>().health;
    }

    public void SetMaxHealth()
    {
        slide.maxValue = player.GetComponent<Entity>().health;
        slide.value = player.GetComponent<Entity>().health;
    }



    
    public void Update() {
        slide.value = player.GetComponent<Entity>().health;
        fill.color = gradient.Evaluate(slide.normalizedValue);
    }
    
}
