using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishMovement : MonoBehaviour
{

    // movement speed
    public float speed = 2;

    // swim Force
    public float swimForce = 300;

    // Use this for initialization
    void Start()
    {
        // swim to the right side
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // swim upper
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * swimForce);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart - for this time
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
