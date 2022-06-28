using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(180 * speedX * Time.deltaTime, 180 * speedY * Time.deltaTime, 180 * speedZ * Time.deltaTime);
    }
}
