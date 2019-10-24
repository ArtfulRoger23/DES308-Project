using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Target : MonoBehaviour
{

    public bool isEnemy = false;

    public float delta = 0.1f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;

    float deltaTimer = 0f;


    void Start()
    {
        startPos = transform.position;
        
    }

    void Update()
    {
        deltaTimer += Time.deltaTime;

        Vector3 targetDirection = transform.forward;
        float targetMagnitude = delta * Mathf.Sin(deltaTimer * speed);
        

        transform.position += targetDirection * targetMagnitude;
    }


}
