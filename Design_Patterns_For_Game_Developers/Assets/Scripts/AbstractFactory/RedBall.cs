using UnityEngine;

/// <summary>
/// Concrete Product from the Factory
/// </summary>
internal class RedBall : MonoBehaviour, IBall
{
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

    public void Deactivate()
    {
        gameObject.SetActive(false);
        
    }
}