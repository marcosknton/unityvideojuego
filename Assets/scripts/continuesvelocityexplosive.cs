using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuesvelocityexplosive : MonoBehaviour {

    public GameObject explosion2_0;
    public GameObject paquete2;
    public Vector2 velocity;
   
    // Update is called once per frame


    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (GameObject.Find("run") == null|| GameObject.Find("policia_0"))
        {
            explosion2_0.GetComponent<Animator>().SetBool("explosion", false);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D coll)
    {
        //si colision contra un coche destruyelo
        if (coll.gameObject.tag == "ship")
        {
            Destroy(coll.gameObject);
            Instantiate(explosion2_0, transform.position, Quaternion.identity);
            
           
        }

        if (coll.gameObject.tag == "enemy")
        {
            Destroy(coll.gameObject);
            Instantiate(paquete2, transform.position, Quaternion.identity);
            Instantiate(explosion2_0, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

    }


}
