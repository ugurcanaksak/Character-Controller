

public interface ICharacterHealthController
{

    float CurrentHealth {get;}

    void TakeDamage(float damage);
    void Heal(float health);
}
