using UnityEngine;

namespace Player
{
    public class Player : Person.Person
    {
        [SerializeField] private int exp;

        public int Exp
        {
            get => exp;
            private set => exp = value;
        }

        public override void ShowStat()
        {
            Debug.Log($"Player name: {Name} / Player experience: {Exp}");
        }
    }
}
