using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomFloor : MonoBehaviour
{
    Vector3 defaultPos;

    void Start()
    {
        defaultPos = gameObject.transform.position;
    }

   
    void OnTriggerEnter(Collider other) {
        if(other.tag == "RespawnPoint"){
            Debug.Log("Respawn");
            gameObject.transform.position = defaultPos;
        }
    }
}
