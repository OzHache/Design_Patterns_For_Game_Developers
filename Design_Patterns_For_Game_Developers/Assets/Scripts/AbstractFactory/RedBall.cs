using UnityEngine;

/// <summary>
/// Concrete Product from the Factory
/// </summary>
public class RedBall : MonoBehaviour, IBall
{
    //Launches the ball and makes sure the gameObject is active
    public void Activate()
    {
        Vector3 velocity = transform.forward * 10.0f;
        gameObject.SetActive(true);
        Rigidbody rb = GetComponent<Rigidbody>();
        if(rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.velocity = velocity;
    }

    //Unused the the Abstract Factory
    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}