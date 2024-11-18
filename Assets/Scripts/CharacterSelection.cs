using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class CharacterSelection : MonoBehaviour
{
    #region Public Variables
    public CharacterController marioPrefab;
    public CharacterController mariaPrefab;
    public static CharacterController selectedCharacter;
    #endregion

    #region Public Methods
    public void SelectedCharacter_1()
    {
        selectedCharacter = marioPrefab;
    }

    public void SelectedCharacter_2()
    {
        selectedCharacter = mariaPrefab;
    }
    #endregion
}
