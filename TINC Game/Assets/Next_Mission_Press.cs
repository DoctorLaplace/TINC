using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Mission_Press : MonoBehaviour
{
    public int tick = 0;
    public AudioManager music_controller;
    public string next_mission_name; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tick += 1;

        if (tick > 40){
            tick = 0;
            if (gameObject.GetComponent<SpriteRenderer>().enabled == false){
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
        }

        if (Input.GetKeyDown("space"))
        {
            FindObjectOfType<AudioManager>().Play("Button_Pressed");
            SceneManager.LoadScene(next_mission_name);
        }

    }
}
