using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speedx, speedy, speedz;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedx*Time.deltaTime, speedy * Time.deltaTime, speedz * Time.deltaTime);
    }
}
