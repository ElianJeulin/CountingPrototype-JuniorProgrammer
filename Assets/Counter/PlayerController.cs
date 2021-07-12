using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool endGame = false;
    private int turnSpeed = 50;
    private int speed = 30;
    [SerializeField] private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && !endGame)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        endGame = true;
        playerRb.AddRelativeForce(Vector3.right * speed, ForceMode.Impulse);
    }
}
