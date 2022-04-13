using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [Header("File in here")]
    public CharacterData_SO characterTemplateData;

    [Header("Leave empty if you are testing")]
    public CharacterData_SO characterData;

    public int maxHealth { get => characterData?.maxHealth ?? 0; set => characterData.maxHealth = value; }
    public int currentHealth { get => characterData?.currentHealth ?? 0; set => characterData.currentHealth = value; }

    void Awake()
    {
        if (characterTemplateData != null)
        {
            characterData = Instantiate(characterTemplateData);
        }
    }
}
