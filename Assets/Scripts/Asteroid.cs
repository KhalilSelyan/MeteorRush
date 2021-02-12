using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject explosion;
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * 40;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "OutOfBounds")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Beam" || col.gameObject.tag == "SpaceShip")
        {
            Instantiate(explosion, col.transform.position, Quaternion.identity);
            scoreScript.scoreValue = scoreScript.scoreValue + 75;
            Destroy(this.gameObject);
        }

        
    }
    
}
