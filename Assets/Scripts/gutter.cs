using UnityEngine;

public class gutter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider triggeredBody)
    {
        if (triggeredBody.CompareTag("ball"))
        {
            Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();
            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
