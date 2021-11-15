using System.Linq;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            DealDamageToNearestCharacter();
        }
    }

    private void DealDamageToNearestCharacter()
    {
        Character nearestCharacter = FindObjectsOfType<Character>()
            .OrderBy(t => Vector3.Distance(transform.position, t.transform.position))
            .FirstOrDefault();

        int damageToDeal = 1;

        if (nearestCharacter is NPC)
        {
            damageToDeal *= 5;
        }

        nearestCharacter.TakeDamage(damageToDeal);
    }
}
