
using UnityEngine;

public abstract class CharacterControllerBase : MonoBehaviour, ICharacterController
{
    [SerializeField]
    private CharacterMovementData characterMovementData;
    protected CharacterMovementData CharacterMovementData => characterMovementData;

    private float currentSpeed;
    public float CurrentSpeed => currentSpeed;

    private bool CanMove;

    public bool canMove => CanMove;

    public abstract void Crouch();


    public abstract void Jump(float jumpForce);


    public abstract void Move(Vector3 direction);

}
