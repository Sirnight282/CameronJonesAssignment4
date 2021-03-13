using UnityEngine;

public class Rotator : MonoBehaviour
{
    public static float speed;
    public float multiplier;
    private void Start()
    {
        multiplier = SliderValueToText.sliderValueFloat;
        speed = 100f;
    }
    void Update()
    {
        transform.Rotate(0f, 0f, speed * multiplier * Time.deltaTime);
        //Debug.Log("Speed " + speed);
        //Debug.Log("Speed * multiplier " + speed * multiplier);
    }
}
