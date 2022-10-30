// For God so loved the world, that He gave His only begotten Son, that all who believe in Him should not perish but have everlasting life
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomba_move_chirho : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
