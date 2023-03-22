using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SuriviveProject
{
    public class CharacterMovable : MonoBehaviour, IMovable, IInitializable
    {
        private MainStats Stats => character.mainStat;

        private Character character;

        public void Initialize()
        {
            character = GetComponent<Character>();
        }

        public void Move(Vector2 translation, Space space = Space.Self)
        {
            transform.Translate(translation * Stats.Speed, space);
        }       
    }
}

