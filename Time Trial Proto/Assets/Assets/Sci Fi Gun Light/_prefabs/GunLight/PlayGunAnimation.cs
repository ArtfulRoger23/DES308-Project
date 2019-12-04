using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGunAnimation : MonoBehaviour
{

    public Animator GunAnimationController;

    private void Start()
    {
        GunAnimationController = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GunAnimationController.Play("GunShoot");
        }
        
    }
}
