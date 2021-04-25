using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float MovementSpeed;
    private void Start()
    {
        
    }

    private void Update()
    {
        //Basic left and right movement.
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}



// Made by Brandixitor