using UnityEngine;

public class NPC : Character
{
    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount * 5);
    }
}
