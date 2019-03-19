
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float t;

	// Use this for initialization
	void Start () {

        t = 0;
	}
	
	// Update is called once per frame
	void Update () {

        t += Time.deltaTime;

        gameObject.GetComponent<Text>().text = string.Format("{0:00}:{1:00}.{2:00}",
           Mathf.Floor(t / 60),
           Mathf.Floor(t) % 60,
           Mathf.Floor((t * 100) % 100));
    }
}
