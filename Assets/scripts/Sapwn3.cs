using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapwn3 : MonoBehaviour {

    public GameObject[] ship;
    public UiManager manager;
    int shipNo;
    public int min;
    public float interval = 0.5F;
    UiManager uiManager;


    void Start()
    {

        manager = GameObject.Find("UiManager").GetComponent<UiManager>();
        //llama a SpawnNext cada pocos segundos
        InvokeRepeating("nivel", interval, 0.9f);
    }

    void nivel()
    {
        Vector3 carPos = new Vector3(Random.Range(-3.11f, 3.11f), transform.position.y, transform.position.z);
        shipNo = Random.Range(0, 8);
        Instantiate(ship[shipNo], carPos, Quaternion.identity);
    }

}
