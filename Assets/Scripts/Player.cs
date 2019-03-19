using UnityEngine;

public class Player : MonoBehaviour {
    private float vel;


    // Use this for initialization
    void Start () {

        vel = 0.1f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position = new Vector2(transform.position.x + vel * inputX,transform.position.y);

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Top_Boundarie"))
        {
            SceneLoader.LoadMainGameScene();
        }
    }

}
