using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform spawn;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = spawn.transform.position;
        Debug.Log(other.transform.name);
    }



}
