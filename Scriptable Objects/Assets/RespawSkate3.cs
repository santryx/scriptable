using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawSkate3 : MonoBehaviour
{

    public string Skatename;
    public float supervelocity;
    public GameObject skate;
    public Transform respawn;
    public int puestoDePoder3;
    public bool poder3;
    public move mueve3;

    public ArtefactoBeneficio artefactoBeneficio;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        poder3 = mueve3.poder;
        puestoDePoder3 = mueve3.puestoDePoder;

        if (puestoDePoder3 == 2 && poder3 == true)
        {
            Skatename = artefactoBeneficio.artefacto;
            supervelocity = artefactoBeneficio.superVelocidad;
            skate = Instantiate(artefactoBeneficio.skateModel, respawn.position, respawn.rotation);
            StartCoroutine("TiempoPower3");
        }
    }

    IEnumerator TiempoPower3()
    {
        yield return new WaitForSeconds(5f);
        poder3 = false;
    }
}
