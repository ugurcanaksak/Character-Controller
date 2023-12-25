using UnityEngine;

public interface ICharacterController 
{
    float CurrentSpeed {get;}
    bool canMove{get;}



    void Move(Vector3 direction);
    void Jump(float jumpForce);
    void Crouch();
}
