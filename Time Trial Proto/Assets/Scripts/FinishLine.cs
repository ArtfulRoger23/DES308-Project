﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    public GameObject PlayerFPSController;
    private CharacterController charController;
    public Shooting stopShooting;

    

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Main Menu");

    }
        private void OnTriggerStay(Collider other)
    {
        
        GameObject.Find("PlayerFPSController").SendMessage("Finish");

        charController = GetComponent<CharacterController>();
        PlayerFPSController.GetComponent<CharacterController>().enabled = false;

        stopShooting.GetComponent<Shooting>().enabled = false;

        StartCoroutine(WaitForSceneLoad());

        

    }


}