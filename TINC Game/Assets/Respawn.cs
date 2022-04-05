/*BY::Cebastian Santiago 
 * CS370 Unity 2D Game Project
 * Code Respawns player and has visible 
 * checks points.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour{
    // Start is called before the first frame update
    public float respawnDelay;
    public Player_Controller controller;
    public Respawn delay;
    
    //varaibles to restart the player to start position
    public Sprite redFlag;
    public Sprite greenFlag;
    
    private SpriteRenderer checkpointsprite;
    public bool checkpointreached;
    private Vector3 respawnpoint;
    public GameObject fallDetector;



    void Start(){
        //detects the starting position of the player
        respawnpoint = transform.position;
        checkpointsprite = GetComponent<SpriteRenderer>();
    }





    // Update is called once per frame
    void Update(){
        
    }
    
    /// <summary>
    /// Is the FallDetector objects that detects if the user 
    /// fall down and restarts the object player to the starting point
    /// </summary>
    /// <param name="collison"></param>
    private void OnTriggerEnter2D(Collider2D collison){
        
        if (collison.tag == "FallDetector"){
                transform.position = respawnpoint;
        }

         if (collison.tag == "checkpoint"){
            respawnpoint = transform.position;
        }
        
        
          if(collison.tag == "Player"){
            checkpointsprite.sprite = greenFlag;
            checkpointreached = true;
         }
        
    }


}
