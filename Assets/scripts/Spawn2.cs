using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour {

    public GameObject[] ship2;
    public UiManager manager;
    int shipNo;
    public int min;
    public int seg;
    public float interval =0.5F;
	UiManager uiManager;
    
   
    void Start()
    {
        
		manager = GameObject.Find("UiManager").GetComponent<UiManager>();
        //llama a SpawnNext cada pocos segundos
       InvokeRepeating("nivel", interval,0.9f );
    }

    private void Update()
    {
        seg = manager.getseg();
    }

    void nivel() {
        if (seg<57) {
            Vector3 carPos = new Vector3(Random.Range(-3.11f, 3.11f), transform.position.y, transform.position.z);
            shipNo = Random.Range(0, 7);
            Instantiate(ship2[shipNo], carPos, Quaternion.identity);
        }
    }

}


