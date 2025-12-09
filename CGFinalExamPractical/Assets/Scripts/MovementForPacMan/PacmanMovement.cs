using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    public float speed = 16f; // Movement speed
    Rigidbody rb;
                             
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input values
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Movement direction
        Vector3 direction = new Vector3(horizontal, vertical, 0f); // Moved Vertical value to the y position and moved 0f to the z position in the vector3

        // Apply movement
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

