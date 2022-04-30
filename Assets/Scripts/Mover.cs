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
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {   
        MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player by using the WASD keys or the arrow keys");
        Debug.Log("The Objective of the game is to avoid the obstacles and reach the end");
    }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;//move left and right
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;//move up and down
        
        transform.Translate(xValue,0,zValue);
    }
}
