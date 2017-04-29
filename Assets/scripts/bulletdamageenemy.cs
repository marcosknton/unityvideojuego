using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamageenemy : MonoBehaviour {

    public GameObject boom;
    public GameObject barril;
    

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //si colision contra un coche destruyelo
        if (coll.gameObject.tag == "ship")
        {
            Destroy(coll.gameObject);
            Instantiate(boom, transform.position, Quaternion.identity);
           
        }

        if (coll.gameObject.tag == "camion_explosivos")
        {
            Destroy(coll.gameObject);
            Instantiate(barril, transform.position, Quaternion.identity);
        }


        //en cualquier caso destruye la bala
        Destroy(gameObject);
    }


    void Update()
    {
       
        if (GameObject.Find("run") == null)
        {
            boom.GetComponent<Animator>().SetBool("explosion", false);
        }
    }
}
