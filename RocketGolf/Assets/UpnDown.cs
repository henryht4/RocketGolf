using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpnDown : MonoBehaviour {

    public float frequency = 1f;    
    public float amplitude = 1f;
    float elapsedTime = 0f;

    Vector3 startPos;
    
    
    void Start()
    {
        startPos = transform.position;
    }
   
    void Update()
    {
        elapsedTime += Time.deltaTime * Time.timeScale * frequency;
        transform.position = startPos + Vector3.up * Mathf.Sin(elapsedTime) * amplitude;
    }
}
