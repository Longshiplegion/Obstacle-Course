using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You have bumped into an object this many times: " + hits);
        
    }
}