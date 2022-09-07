using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//------------------------------------------------------------------------------
//Abstract Factory Client
//Utilizes the Interface on the AbstractFactory(IBall Factory) to generate the
//products (IBall) Red and Blue Balls
//------------------------------------------------------------------------------

public class BallLauncher : MonoBehaviour
{
    //Abstract Factory Interface Reference
    private IBallFactory m_ballFactory;

    //Gather references
    private void Start()
    {
        m_ballFactory = GetComponent<IBallFactory>();
    }

    /// <summary>
    /// Called from Input Action Pressing Key Q, asks for a ball to be created.
    /// Then activates the ball.
    /// </summary>
    private void OnLaunchRedBall()
    {
        // Create the ball
        IBall ballA = m_ballFactory.CreateBallA(transform);

        // Activate the ball
        ballA?.Activate();

    }

    /// <summary>
    /// Called from Input Action Pressing Key E, asks for a ball to be created.
    /// Then activates the ball.
    /// </summary>
    private void OnLaunchBlueBall()
    {
        // Create the ball
        IBall ballB = m_ballFactory.CreateBallB(transform);
        
        //Activate
        ballB?.Activate();
    }
}
