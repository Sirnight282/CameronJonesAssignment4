using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;
    public float multiplier;
       

    private void Start()
    {
        multiplier = PinSlider.pinSliderValueFloat;
       
    }
    void FixedUpdate()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * multiplier * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            Rotator.speed = Rotator.speed + 10;
            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
                        
        }
    }
    
}
