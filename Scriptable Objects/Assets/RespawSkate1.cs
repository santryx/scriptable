using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawSkate1 : MonoBehaviour
{

    public string Skatename;
    public float supervelocity;
    public GameObject skate;
    public Transform respawn;
    public int puestoDePoder1;
    public bool poder1;

    public move mueve1;

    public ArtefactoBeneficio artefactoBeneficio;

    void Update()
    {
        poder1 = mueve1.poder;
        puestoDePoder1 = mueve1.puestoDePoder;

        if (poder1 == true && puestoDePoder1 == 1)
        {
            Skatename = artefactoBeneficio.artefacto;
            supervelocity = artefactoBeneficio.superVelocidad;
            skate = Instantiate(artefactoBeneficio.skateModel, respawn.position, respawn.rotation);
            StartCoroutine("TiempoPower1");

        }


    }

    IEnumerator TiempoPower1()
    {
        yield return new WaitForSeconds(5f);
        poder1 = false;
    }
}
