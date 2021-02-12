using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public GameObject TealExplosion;
    public GameObject RedExplosion;
    public float speed = 35;
    string axis1 = "Vertical";
    string axis2 = "Horizontal";
    void Update()
    {
        moveThat();
    }
    void moveThat()
    {
        float v = Input.GetAxisRaw(axis1);
        float h = Input.GetAxisRaw(axis2);
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
                Instantiate(TealExplosion, this.transform.position, Quaternion.identity); // the explosion at the ship's position
                Instantiate(RedExplosion, col.transform.position, Quaternion.identity); // the explosion at the asteroid's position
                StartCoroutine(GameOver());
                GetComponent<SpriteRenderer>().enabled = false; // if i delete this gameObject the script doesn't finish so instead just make it disappear from the screen
                Destroy(col.gameObject);
        }
    }

 
    private IEnumerator GameOver()
    {
        yield return new WaitForSecondsRealtime(0.75f); // just about enough time for the explosion animations to finish.
        SceneManager.LoadScene(3); // Loading Game Over Scene
    }
}
