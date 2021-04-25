using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float MovementSpeed;
    private bool facingRight;
    private void Start()
    {
        
    }

    private void Update()
    {
        //Basic left and right movement.
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }

    private void Flip()
    {
        //Character left and right 180 flips.
        
    }
}



// Made by Brandixitor