using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="skatepower", menuName ="skateartefacto")]
public class ArtefactoBeneficio : ScriptableObject
{
    public string artefacto;
    public float velocidad;
    public float salto;
    public float superVelocidad;
    public enum tipodeTablas
    { 
        Skatevel, Skatejump, Skateinferno
    };

    public tipodeTablas skateselect;
    public GameObject skateModel;
    
}
