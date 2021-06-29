using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lesson
{ 
    [CreateAssetMenu(menuName = "Lesson/Lesson1/Rotate Settings")]
    public class ilkkodSettings : ScriptableObject
    {
        public int pblc = 100;
        [SerializeField]public int sildim = 100;

    }
}