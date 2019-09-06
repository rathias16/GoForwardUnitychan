using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private float speed = -0.2f;

    private float deadline = -10;

    AudioSource audiosource;

    public AudioClip block;
	// Use this for initialization
	void Start () {
        audiosource = GetComponent<AudioSource>();

        audiosource.clip = block;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);

        if(transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GroundTag" || collision.gameObject.tag == "BlockTag")
        {
            audiosource.Play();
        }
    }
}
