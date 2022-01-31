using System;
using UnityEngine;
/// <summary>
/// Concrete Implimentation of the Abstract Factory
/// </summary>
internal class RedBlueBallFactory : MonoBehaviour, IBallFactory
{
    [SerializeField] GameObject m_redBall;
    [SerializeField] GameObject m_blueBall;
    //IBallFactory Interface implimentation

    public IBall CreateBallA(Transform launchPoint)
    {
        GameObject ball = Instantiate(m_redBall, launchPoint.position, launchPoint.rotation);
        return ball.AddComponent<RedBall>();
    }

    public IBall CreateBallB(Transform launchPoint)
    {
        GameObject ball = Instantiate(m_blueBall, launchPoint.position, launchPoint.rotation);
        return ball.AddComponent<BlueBall>();
    }

}