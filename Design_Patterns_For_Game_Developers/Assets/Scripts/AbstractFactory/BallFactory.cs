using UnityEngine;
//Interface for the Abstract Ball Factory
internal interface IBallFactory
{
    public IBall CreateBallA(Transform m_launchPoint);
    public IBall CreateBallB(Transform m_launchPoint);
}