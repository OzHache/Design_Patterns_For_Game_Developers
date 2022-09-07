using UnityEngine;

//------------------------------------------------------------------------------
//Interface for the Abstract Ball Factory
//------------------------------------------------------------------------------

public interface IBallFactory
{
    //The only interfaces that the client can use
    public IBall CreateBallA(Transform m_launchPoint);
    public IBall CreateBallB(Transform m_launchPoint);
}