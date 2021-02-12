using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraAsteroid : MonoBehaviour
{
    public GameObject explosion;
    private Vector2 vec;

    void Update()
    {
        Vector2 vec = new Vector2(-1, Random.Range(-1f,1f)); // I think this is closer to a sine wave movement in a way but still very inconsistent
        GetComponent<Rigidbody2D>().velocity = vec * 60;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "OutOfBounds")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "OutOfBoundsUpDown")  // Just in case it hits the lower or upper bound it switches the y value to make it go the other way
        { 
            {
                vec = new Vector2(vec.x,-vec.y);
            }
        }
        if (col.gameObject.tag == "Beam" || col.gameObject.tag == "SpaceShip")
        {
            Instantiate(explosion, col.transform.position, Quaternion.identity);
            scoreScript.scoreValue = scoreScript.scoreValue + 125;
            Destroy(this.gameObject);
        }
        
    }
}
