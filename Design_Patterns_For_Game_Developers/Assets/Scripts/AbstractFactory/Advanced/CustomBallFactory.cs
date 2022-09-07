using UnityEngine;
using System.Collections;

public class CustomBallFactory : MonoBehaviour , IBallFactory
{
    [SerializeField] GameObject m_prefabA;
    [SerializeField] GameObject m_prefabB;


    public IBall CreateBallA(Transform m_launchPoint)
    {
        Instantiate(m_prefabA, m_launchPoint.position, m_launchPoint.rotation);
        return m_prefabA.GetComponent<BallBehaviour>();
    }

    public IBall CreateBallB(Transform m_launchPoint)
    {
        Instantiate(m_prefabB, m_launchPoint.position, m_launchPoint.rotation);
        return m_prefabA.GetComponent<BallBehaviour>();
    }
}
