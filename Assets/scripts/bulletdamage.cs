using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage : MonoBehaviour {

    public GameObject paquete2;
    public GameObject barril;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //si colision contra un coche destruyelo
        if (coll.gameObject.tag == "enemy")
        {
            Destroy(coll.gameObject);
            Instantiate(paquete2, transform.position, Quaternion.identity);
           
        }

        if (coll.gameObject.tag == "camion_explosivos")
        {
            //Destroy(coll.gameObject);
            Instantiate(barril,new Vector2(transform.position.x+2, transform.position.y+3) , Quaternion.identity);
            Instantiate(barril, new Vector2(transform.position.x + -2, transform.position.y + 3), Quaternion.identity);
        }



        //en cualquier caso destruye la bala
        Destroy(gameObject);
    }
}
