using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionRIP : MonoBehaviour
{
    private void FixedUpdate()
    {
        Destroy(gameObject,0.75f); // to delete the explosion animation after it ends
    }
}
