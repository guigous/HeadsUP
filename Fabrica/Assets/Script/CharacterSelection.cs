using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] PersonagemPanel characterPanelLeft;

    [SerializeField] PersonagemPanel characterPanelRight;

    [SerializeField] PersonagemPanel characterPanelMiddle;

    void Start()
    {
        CharacterList.instance.SelectCharIndex = 0;
        UpdateCharacterPanels();
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CharacterList.instance.SelectCharIndex--;
            Debug.Log("left");
            UpdateCharacterPanels();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CharacterList.instance.SelectCharIndex++;
            Debug.Log("right");
            UpdateCharacterPanels();
        }

    }

    private void UpdateCharacterPanels()
    {
        characterPanelLeft.UpdateCharacterPanel(CharacterList.instance.GetPrevious());

        characterPanelMiddle.UpdateCharacterPanel(CharacterList.instance.currentCharacter);

        characterPanelRight.UpdateCharacterPanel(CharacterList.instance.GetNext());
    }

}
