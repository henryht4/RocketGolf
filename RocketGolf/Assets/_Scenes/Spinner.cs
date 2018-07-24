using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

	
    void Update()
    {
        transform.Rotate(new Vector3(15, 0, 0) * Time.deltaTime);
    }
}
