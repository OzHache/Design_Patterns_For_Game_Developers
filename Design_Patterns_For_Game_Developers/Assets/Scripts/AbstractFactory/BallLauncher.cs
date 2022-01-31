using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract Factory Client
//Utilizes the Interface on the AbstractFactory to generate the product(Red and Blue Balls)
public class BallLauncher : MonoBehaviour
{
    //Interface
    private IBallFactory m_ballFactory;

    private void Start()
    {
        m_ballFactory = GetComponent<IBallFactory>();
    }

    private void OnLaunchRedBall() {
        // Create the ball
        IBall ballA = m_ballFactory.CreateBallA(transform);
        // Escape if the ball failed to be created
        if (ballA == null) return;
        // Activate the ball
        ballA.Activate();

    }
    private void OnLaunchBlueBall() {
        // Create the ball
        IBall ballB = m_ballFactory.CreateBallB(transform);
        // Escape if the ball failed to be created
        if (ballB == null) return;
        // Activate the ball
        ballB.Activate();
    }
}
