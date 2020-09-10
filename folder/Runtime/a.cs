using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test.test
{
    public class a : MonoBehaviour
    {
        public static string hello = "hello from main";

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(hello);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}