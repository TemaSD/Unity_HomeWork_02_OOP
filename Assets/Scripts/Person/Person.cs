using UnityEngine;

namespace Person
{
    public abstract class Person : MonoBehaviour
    {
        [SerializeField] private int health;
        [SerializeField] private new string name;

        public string Name
        {
            get => name;
            private set => name = value;
        }

        public int Health
        {
            get => health;
            set
            {
                if (value is < 0 or > 100)
                    Debug.Log("Error: Incorrect health. Must be in range 0->100");
                else
                    health = value;
            }
        }

        public virtual void ShowStat()
        {
            Debug.Log($"Player name: {Name}");
        }

        public abstract void TakeDamage(int damageValue);
    }
}
