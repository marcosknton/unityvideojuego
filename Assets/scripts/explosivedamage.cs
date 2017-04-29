using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosivedamage : MonoBehaviour {

    public GameObject barril;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //si colision contra un coche destruyelo
        if (coll.gameObject.tag == "camion_explosivos")
        {
            Instantiate(barril, new Vector2(transform.position.x -1, transform.position.y), Quaternion.identity);

        }
    }
}
