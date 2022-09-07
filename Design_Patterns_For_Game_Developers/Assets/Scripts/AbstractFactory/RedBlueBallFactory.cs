using UnityEngine;
/// <summary>
/// Concrete Implimentation of the Abstract Factory
/// </summary>
public class RedBlueBallFactory : MonoBehaviour, IBallFactory
{
    //Types of Balls I can create
    private enum BallType { Red, Blue }

    [SerializeField] private GameObject m_ballPrefab;
    //Red Ball
    [Header("Red Ball Properties")]
    [SerializeField] private Material m_redBallMaterial;
    //Blue Ball
    [Header("Blue Ball Properties")]
    [SerializeField] private Material m_blueBallMaterial;


    //IBallFactory Interface implimentation

    public IBall CreateBallA(Transform launchPoint)
    {
        return CreateBall(launchPoint, BallType.Red);
    }

    public IBall CreateBallB(Transform launchPoint)
    {
        return CreateBall(launchPoint, BallType.Blue);
    }

    //Extendable Method to create balls of different types
    private IBall CreateBall(Transform launchPoint, BallType type)
    {
        //Create the Ball instance
        GameObject ball = Instantiate(m_ballPrefab, launchPoint.position, launchPoint.rotation);

        //Return the ball to the Client
        IBall ballComponent;
        switch (type)
        {
            //Generate Ted Ball
            case BallType.Red:
                ball.GetComponent<Renderer>().material = m_redBallMaterial;
                ballComponent = ball.AddComponent<RedBall>();
                break;

            //Generate Blue Ball
            case BallType.Blue:
                ball.GetComponent<Renderer>().material = m_blueBallMaterial;
                ballComponent = ball.AddComponent<BlueBall>();
                break;

            default:
                return null;
        }
        return ballComponent;
    }
}