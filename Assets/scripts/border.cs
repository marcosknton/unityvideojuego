using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour {

    // Use this for initialization
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name != "run")
            Destroy(coll.gameObject);
    }
}
