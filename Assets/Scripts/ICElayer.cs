
using UnityEngine;

public class ICElayer : MonoBehaviour {

    public float vel;


    // Use this for initialization
    void Start()
    {

        vel = 0.05f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + vel);

        if (transform.position.y >= 6.62) { transform.position = new Vector2(  Random.Range(-2.7f, 2.7f), -7.3f); 
        }



    }
}
