using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Target : MonoBehaviour
{
   
    public bool isEnemy = false;

    public float delta = 0.1f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;


    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {/*
        Vector3 v = startPos;
        v.z += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;*/

        Vector3 targetDirection = transform.forward;
        float targetMagnitude = delta * Mathf.Sin(Time.time * speed);
        

        transform.position += targetDirection * targetMagnitude;
    }


}
