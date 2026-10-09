
using UnityEngine;
using UnityEngine.UI;

public class BowlingBallController : MonoBehaviour
{
    private GameObject bowlingBall;
    private bool bowled; 

    public float bowlStrength;

    void Start()
    {
        bowlingBall = gameObject;
        bowled = false;
    }

    void Update()
    {

    }

    public void Aim(Slider horizontalDirection)
    {
        if (bowled)
        {
            return;
        }

        bowlingBall.transform.rotation = Quaternion.Euler(90f, horizontalDirection.value, 0f);
    }

    public void Bowl()
    {
        if(bowled)
        {
            return;
        }
        bowled = true;

        Vector3 forwardsVector = new Vector3(0, 1, 0);
        Quaternion bowlingAngle = Quaternion.Euler(90f, bowlingBall.GetComponent<Rigidbody>().transform.eulerAngles.z, 0f);
        Vector3 bowlingforce = bowlingAngle * forwardsVector * bowlStrength;
        print(bowlingforce);
        bowlingBall.GetComponent<Rigidbody>().AddForce(bowlingforce);
    }
}
