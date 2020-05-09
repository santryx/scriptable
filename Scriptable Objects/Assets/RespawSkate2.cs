using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawSkate2 : MonoBehaviour
{

    public string Skatename;
    public float supervelocity;
    public GameObject skate;
    public Transform respawn;
    public int puestoDePoder2;
    public bool poder2;

    public ArtefactoBeneficio artefactoBeneficio;
    public move mueve2;
    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        poder2 = mueve2.poder;
        puestoDePoder2 = mueve2.puestoDePoder;

        if (puestoDePoder2 == 2 && poder2 == true)
        {
            Skatename = artefactoBeneficio.artefacto;
            supervelocity = artefactoBeneficio.superVelocidad;
            skate = Instantiate(artefactoBeneficio.skateModel, respawn.position, respawn.rotation);
            StartCoroutine("TiempoPower2");

        }
    }

    IEnumerator TiempoPower2()
    {
        yield return new WaitForSeconds(5f);
        poder2 = false;
    }
}
