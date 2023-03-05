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
        CharacterList.Instance.SelectCharIndex = 0;
        UpdateCharacterPanels();
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharacterList.Instance.SelectCharIndex--;
            Debug.Log("left");
            UpdateCharacterPanels();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            CharacterList.Instance.SelectCharIndex++;
            Debug.Log("right");
            UpdateCharacterPanels();
        }

    }

    private void UpdateCharacterPanels()
    {
        characterPanelLeft.UpdateCharacterPanel(CharacterList.Instance.GetPrevious());

        characterPanelMiddle.UpdateCharacterPanel(CharacterList.Instance.currentCharacter);

        characterPanelRight.UpdateCharacterPanel(CharacterList.Instance.GetNext());
    }

}
