using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{
    public GameObject PlayerFPSController;
    public GameObject RespawnPoint;
    //[SerializeField] private Transform player;
    //[SerializeField] private Transform spawn;

    private CharacterController charController;

    void Start()
    {
        //charController = GetComponent<CharacterController>();
    }
    void OnTriggerEnter(Collider other)
    {
        charController = GetComponent<CharacterController>();

        PlayerFPSController.GetComponent<CharacterController>().enabled = false;
        PlayerFPSController.GetComponent<CharacterController>().transform.position = RespawnPoint.transform.position;
        PlayerFPSController.GetComponent<CharacterController>().enabled = true;


        //player.transform.position = spawn.transform.position;
        Debug.Log(other.transform.name);
    }



}
