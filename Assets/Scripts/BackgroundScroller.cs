using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    public float speed = -3.0f;
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    
    void Update()
    {
        // Couldn't find a better way to scroll the background as it has a weird transition when it loops back it's a bit ugly
        float newPos = Mathf.Repeat(Time.time * speed, 60);
        transform.position = startPos + newPos * Vector2.right;
    }
}
