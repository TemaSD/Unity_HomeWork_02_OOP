using UnityEngine;

namespace Dragon
{
    public class Dragon : Person.Person
    {
        public override void TakeDamage(int damageValue)
        {
            Debug.Log($"I, the mighty dragon, have lost: {damageValue} hit points from a hunter's shot.");
        }
    }
}
