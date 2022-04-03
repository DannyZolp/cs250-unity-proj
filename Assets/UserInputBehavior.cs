using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputBehavior : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 up = Input.GetButton("Jump") ? transform.up * m_Thrust : new Vector3();
        Vector3 forwardAndBackwards = transform.forward * Input.GetAxis("Vertical") * m_Thrust;
        Vector3 leftAndRight = transform.right * Input.GetAxis("Horizontal") * m_Thrust;


        m_Rigidbody.velocity += up + forwardAndBackwards + leftAndRight;
    }
}
