using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpew : MonoBehaviour
{
    public GameObject Beam;
    public AudioClip pew;
    new private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void ShootLaser()
    {
        if (Input.GetKeyDown("space"))
        {
            Vector3 pos = GameObject.Find("ship2").transform.position; // to spawn the laser from the ship's position
            audio.PlayOneShot(pew,1f);
            Instantiate(Beam,pos,Quaternion.identity);
        }

    }

    void Update()
    {
        ShootLaser();
    }
}
