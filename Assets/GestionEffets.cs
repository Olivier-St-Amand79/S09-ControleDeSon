using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionEffets : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;
    public void ChangerVolumeEffets(float nouveauVolumeEffets)
    {
        Debug.Log("Changer volume effets " + nouveauVolumeEffets);
        _mixer.SetFloat("VolumeEffets", nouveauVolumeEffets);
    }
}
