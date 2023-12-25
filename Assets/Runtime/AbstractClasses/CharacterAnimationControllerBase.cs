using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterAnimationControllerBase : MonoBehaviour, ICharacterAnimationController
{
    private Animator animator;
    protected Animator Animator {get {return animator == null ? animator=GetComponentInChildren<Animator>() : animator; }}

    public abstract void ApplyAnimation();

}
