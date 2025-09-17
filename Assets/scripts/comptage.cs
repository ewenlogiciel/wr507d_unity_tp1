using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SolScript : MonoBehaviour
{
    public TMP_Text PointsText;
    int compteur;

    void Start()
    {
        PointsText.text = "0";
        compteur = 0;
    }

void OnTriggerEnter(Collider other) {
        if (other.CompareTag("to_fall"))
        {
            compteur++; // ajoute 1 à la valeur "compteur"
            Debug.Log(compteur); // Affiche la valeur de compteur
            PointsText.text = compteur.ToString(); // Met à jour le texte

        Destroy(other.gameObject); 
    }

}

}
