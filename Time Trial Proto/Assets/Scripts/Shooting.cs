using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    private AudioSource mAudioSrc;
    public float range = 100f;
    private float impactForce = 200f;

    ScoreCount scoreCount;

    public Camera fpsCam;

    LevelHandler levelHandler;

    AudioSource source1;
    AudioSource source2;
    private void Start()
    {
        scoreCount = FindObjectOfType<ScoreCount>();
        mAudioSrc = GetComponent<AudioSource>();

        levelHandler = FindObjectOfType<LevelHandler>();

        source1 = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AudioSource>();
        source2 = GameObject.FindGameObjectWithTag("Friendly").GetComponent<AudioSource>();



    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            mAudioSrc.Play();
            Shoot();
            levelHandler.totalShots++;
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
                        source1.Play();
                        Debug.Log("Shot enemy");
                        levelHandler.enemiesHit++;
                    
                    }

                    if (target.isEnemy == false)
                    {
                        scoreCount.score -= 1;
                        source2.Play();
                        levelHandler.friendliesHit++;

                    }

                    hit.rigidbody.AddForce((hit.normal * impactForce) * -1);

                    

                    Destroy(target, 0.1f);
                    


                }
            }
        }
    }

}
