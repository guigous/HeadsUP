using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterList : MonoBehaviour
{
    public static CharacterList instance = null;

    [SerializeField] List<CharacterStats> characters = new List<CharacterStats>();

    private int SelectedCharIndex;

    public int SelectCharIndex
    {
        get { return SelectedCharIndex; }
        set
        {
            if (value < 0) return;
            if (value >= characters.Count) return;

            SelectedCharIndex = value;
            currentCharacter = characters[SelectedCharIndex];
        }
    }

    internal CharacterStats currentCharacter;

    void Awake()
    {
        instance = this;
    }

    public CharacterStats GetPrevious()
    {
        var index = SelectCharIndex - 1;
        if (index < 0) return null;
        return characters[SelectCharIndex - 1];
    }
    public CharacterStats GetNext()
    {
        var index = SelectCharIndex + 1;
        if (index >= characters.Count) return null;
        return characters[SelectCharIndex - 1];
    }






}
