using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] float moveSpeed = 0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;//move left and right
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;//move up and down
        
        transform.Translate(xValue,0,zValue);
    }
}
