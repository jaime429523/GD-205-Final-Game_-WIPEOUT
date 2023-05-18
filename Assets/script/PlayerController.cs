using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class PlayerController : MonoBehaviour
{
    
    public float movementSpeed = 1f;
    public float rotationSpeed = 1f;

    private void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);

        Camera.main.transform.Rotate(Vector3.right, -mouseY * rotationSpeed * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Restart the game
            RestartGame();
        }
        if (collision.gameObject.CompareTag("Lava"))
        {
            RestartGame();
        }
        if (collision.gameObject.CompareTag("ProjectileFast"))
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


    
