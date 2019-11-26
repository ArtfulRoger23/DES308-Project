using UnityEngine;

//[ExecuteAlways]
[RequireComponent(typeof(Rigidbody))]
public class Target : MonoBehaviour
{

    public bool isEnemy = false;

    public float delta = 0.1f;  // Amount to move left and right from the start point
    public float speed = 2.0f;

    Vector3 offset;
    Vector3 offsetWorld;

    void Start()
    {
        offset = transform.localPosition;
        offsetWorld = transform.position;
    }

    void Update()
    {

        if (speed != 0)
            transform.localPosition = offset + transform.forward * Mathf.PingPong(Time.time * speed, delta);
       
    }

    private void OnDrawGizmos()
    {
        if (Application.IsPlaying(this) == true)
        {
            Gizmos.DrawSphere(offsetWorld + transform.forward * delta, 0.2f);
        }
        else
        {
            Gizmos.DrawSphere(transform.position + transform.forward * delta, 0.2f);
        }

        
    }


}
