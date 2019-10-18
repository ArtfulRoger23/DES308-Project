using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class Respawn : MonoBehaviour
{
    public GameObject PlayerFPSController;
    public GameObject RespawnPoint;
    

    private CharacterController charController;

    LevelManager LevelManager;
    void Start()
    {
        LevelManager = FindObjectOfType<LevelManager>();
    }


    void OnTriggerEnter(Collider other)
    {
        charController = GetComponent<CharacterController>();

        PlayerFPSController.GetComponent<CharacterController>().enabled = false;
        PlayerFPSController.GetComponent<CharacterController>().transform.position = RespawnPoint.transform.position;
        PlayerFPSController.GetComponent<CharacterController>().enabled = true;
        LevelManager.IncrementDeaths();



        //player.transform.position = spawn.transform.position;
        Debug.Log(other.transform.name);
    }



}
