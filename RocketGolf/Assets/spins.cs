using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spins : MonoBehaviour {

    private void Update()
    {
        transform.Rotate(new Vector3(0 , 35, 0) * Time.deltaTime);
    }
}
