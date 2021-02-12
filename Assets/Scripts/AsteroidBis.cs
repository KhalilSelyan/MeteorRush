using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBis : MonoBehaviour
{

    // Sadly couldn't figure out how to make it move in a sine wave movement and ended up getting a weird movement
    // So i just kept it ¯\_(ツ)_/¯ it's kind of fun this way too.


    const float pi = 3.14f;
    public GameObject explosion;
    float rando;
    public float MoveSpeed = 20f;
    private Vector3 axis;
    private Vector3 pos;

    void Start()
    {
        int ra = Random.Range(-40, 41);
        pos = transform.position;
        axis = transform.up * ra;

    }

    void FixedUpdate()
    {
        rando = Mathf.Sin(Random.Range(0.0f, 2.0f * pi) * 0.1f);
        pos -= transform.right * Time.deltaTime * MoveSpeed;
        transform.position = pos + axis * rando;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "OutOfBounds")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Beam" || col.gameObject.tag == "SpaceShip")
        {
            Instantiate(explosion, col.transform.position, Quaternion.identity);
            scoreScript.scoreValue = scoreScript.scoreValue + 100;
            Destroy(this.gameObject);
        }
    }

}
