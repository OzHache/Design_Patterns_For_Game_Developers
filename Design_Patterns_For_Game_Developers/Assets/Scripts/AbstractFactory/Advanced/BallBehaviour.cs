using System;
using UnityEngine;
[Serializable]
public class BallBehaviour : MonoBehaviour, IBall
{
    [SerializeField] private Vector3 m_launchDirection;
    [SerializeField] private float m_speed;

    private Vector3 m_velocity
    {
        get {return m_launchDirection.normalized * m_speed;}
    }

    //Launches the ball and makes sure the gameObject is active
    public void Activate()
    {
        gameObject.SetActive(true);

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }

        rb.velocity = m_velocity;
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}