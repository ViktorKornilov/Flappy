using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0,5);
        }
    }
}
