using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class MusicManager : MonoBehaviour
{
// ***********************************************
    #region 1) Definicion de variables
    public static MusicManager instance;
    AudioSource audioSource;
    AudioClip[] audioClips;
    #endregion
// ***********************************************
    #region 2) Funciones de Unity
    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void CambiarMusica(int indice)
    {
        audioSource.clip = audioClips[indice];
    }
    #endregion
// ***********************************************
}

