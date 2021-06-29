using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lesson
{
    public class ilkkod : MonoBehaviour
    {
        public int pblc = 0;
       
        [SerializeField] ilkkodSettings _rotateSettings;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            int a = _rotateSettings.sildim;
        }
    }
}