using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PersonagemPanel : MonoBehaviour
{
    [SerializeField] GameObject transparentPanel;

    [SerializeField] bool showTransparentPanel = false;

    [SerializeField] Image charImage;

    [SerializeField] TMP_Text nameText;

     void Start()
    {
        transparentPanel.SetActive(showTransparentPanel);
    }

    internal void UpdateCharacterPanel(CharacterStats characterStats)
    {
        if (characterStats == null)
        {
            charImage.sprite = null;

            nameText.SetText("");
        }
        else
        {
            charImage.sprite = characterStats.face;

            nameText.SetText(characterStats.charName);
        }
        
    }
}
