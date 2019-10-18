using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooting : MonoBehaviour
{
    private AudioSource mAudioSrc;
    public float range = 100f;
    public float impactForce = 100f;

    ScoreCount scoreCount;

    public Camera fpsCam;




   
    private void Start()
    {
        scoreCount = FindObjectOfType<ScoreCount>();
        mAudioSrc = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            mAudioSrc.Play();
            Shoot();
        }



    void Shoot()
        {
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                Target target = hit.transform.GetComponent<Target>();

                if (target != null)
                {

                    if (target.isEnemy == true)
                    {
                        scoreCount.score += 1;
                    }

                    if (target.isEnemy == false)
                    {
                        scoreCount.score -= 1;
                    }

                    hit.rigidbody.AddForce((hit.normal * impactForce) * -1);

                    

                    Destroy(target, 0.1f);
                    


                }
            }
        }
    }

}
