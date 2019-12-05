using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{
    public GameObject playerFPSController;
    public GameObject respawnPoint;
    

    private CharacterController charController;

    LevelHandler levelHandler;

    
    void Start()
    {
        levelHandler = FindObjectOfType<LevelHandler>();
    }


    void OnTriggerEnter(Collider otherObject)
    {


        if (otherObject.gameObject.CompareTag("Player"))
        {
            charController = GetComponent<CharacterController>();

            playerFPSController.GetComponent<CharacterController>().enabled = false;
            playerFPSController.GetComponent<CharacterController>().transform.position = respawnPoint.transform.position;
            playerFPSController.GetComponent<CharacterController>().enabled = true;

            levelHandler.deaths++;

            DataRecorder.recordDeathPosition3D(transform.position);

            //player.transform.position = spawn.transform.position;
            Debug.Log(otherObject.transform.name);
        }
    }



}
