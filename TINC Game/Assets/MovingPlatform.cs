using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public int startPoint;
    public Transform[] points;  //array of transform points where the platform needs to move
    public bool parentCollision = true;

    private int i; //index of the array

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startPoint].position; //sets starting position of platform
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }

        //moves platform to point with index "i"
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (parentCollision == true){
            collision.transform.SetParent(gameObject.transform.GetChild(0));
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (parentCollision == true){
            collision.transform.SetParent(null);
        }
    }

}
