using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    private int moveSpeed = 5;
    void Update()
    {
        Movement(); 
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = (transform.forward * verticalInput) + (transform.right * horizontalInput);

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }

  
}
