using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class GameManager : MonoBehaviour
{
// ***********************************************
    #region 1) Definicion de variables
    public static GameManager instance;
    GameStates estadoActual;
    
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
    void Start()
    {

    }

    void Update()
    {
        KeyControl();
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales

    void CambioEstado (GameStates state)
    {
        if (estadoActual != state)
        {
            switch (estadoActual)
            {
                case GameStates.MenuInicial:
                    Debug.Log("Menu Inicial");
                    break;
                case GameStates.Jugando:
                    Debug.Log("Jugando");
                    break;
                case GameStates.JuegoPausado:
                    Debug.Log("Juego Pausado");
                    break;
                default:
                    break;
            }
        }

    }
    void KeyControl()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (estadoActual == GameStates.Jugando)
            {
                CambioEstado(GameStates.JuegoPausado);
            }
            else if (estadoActual == GameStates.MenuInicial)
            {
                CambioEstado(GameStates.Jugando);
            }
            else if (estadoActual == GameStates.JuegoPausado)
            {
                CambioEstado(GameStates.MenuInicial);
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (estadoActual == GameStates.Jugando)
            {
                CambioEstado(GameStates.JuegoPausado);
            } else if (estadoActual == GameStates.JuegoPausado)
            {
                CambioEstado(GameStates.Jugando);
            }
        }
    }
    #endregion
// ***********************************************
}

