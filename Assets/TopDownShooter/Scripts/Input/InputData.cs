using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.UserInput
{
    [CreateAssetMenu(menuName ="Topdown Shooter/Camera/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
    }
}
