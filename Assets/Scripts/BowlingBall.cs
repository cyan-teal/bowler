
using UnityEngine;
using UnityEngine.UI;

public class BowlingBallController : MonoBehaviour
{
    private GameObject bowlingBall;

    void Start()
    {
        bowlingBall = gameObject;
    }

    void Update()
    {

    }

    public void Aim(Slider horizontalDirection)
    {
        bowlingBall.transform.rotation = Quaternion.Euler(90f, horizontalDirection.value, 0f);
    }
}
