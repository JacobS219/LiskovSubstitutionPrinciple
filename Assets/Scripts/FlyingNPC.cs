using UnityEngine;

public class FlyingNPC : Character
{
    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount * 2);
    }
}
