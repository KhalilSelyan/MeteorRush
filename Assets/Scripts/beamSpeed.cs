using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamSpeed : MonoBehaviour
{
    float beaSpeed = 45;
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(beaSpeed, 0);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Asteroid" || col.gameObject.tag == "OutOfBounds")
        {
            Destroy(this.gameObject);
        }

    }
}
