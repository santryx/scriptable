using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speedMoving = 7.0f;
    public bool poder;
    public int puestoDePoder;
    Animator personaje;


    // Start is called before the first frame update
    void Start()
    {
        personaje = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 2 * Time.deltaTime * speedMoving);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Power")
        {
            poder = true;
            puestoDePoder = Random.Range(0, 4);

        }
    }
}