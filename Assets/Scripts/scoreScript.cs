using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreScript : MonoBehaviour
{
    Text score;
    public static int scoreValue = 0;
    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Your Score is : " + scoreValue;
    }
}
