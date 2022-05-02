using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody ridgidBody;
    [SerializeField ]float waittime = 0f;
    // Start is called before the first frame update

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        ridgidBody = GetComponent<Rigidbody>();
        ridgidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        
        if(time > waittime)
        {
            renderer = GetComponent<MeshRenderer>();
            renderer.enabled = true;
            ridgidBody = GetComponent<Rigidbody>();
            ridgidBody.useGravity = true;
            
        }
    }
}
