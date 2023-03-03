using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemPanel : MonoBehaviour
{
    [SerializeField] GameObject transparentPanel;
    [SerializeField] bool showTransparentPanel = false;

     void Start()
    {
        transparentPanel.SetActive(showTransparentPanel);
    }
}
