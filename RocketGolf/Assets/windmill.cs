using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windmill : MonoBehaviour {

    private void Update()
    {
        transform.Rotate(new Vector3(0,50,0) * Time.deltaTime);
    }

}
