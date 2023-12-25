using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterHealthControllerBase : MonoBehaviour, ICharacterHealthController
{
    [SerializeField]
    private CharacterHealthData HealthData;
    protected CharacterHealthData characterHealthData => HealthData;

    private float currentHealth;

    public float CurrentHealth => currentHealth;

    public abstract void Heal(float health);


    public abstract void TakeDamage(float damage);

}
