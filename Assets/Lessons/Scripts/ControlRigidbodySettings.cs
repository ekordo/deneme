using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lesson
{
    [CreateAssetMenu(menuName = "Lesson/lesson1/Control Rigidbody Settings")]
    public class ControlRigidbodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpForce;
        public Vector3 JumpForce{get{return _jumpForce;}}

    }
}