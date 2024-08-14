using UnityEngine;
using UnityEngine.UI;

public class AutoClick : MonoBehaviour
{
    void Start()
    {
        // Encontrar o bot�o pelo nome
        GameObject buttonGO = GameObject.Find("[15] Option Node.");

        if (buttonGO != null)
        {
            Button button = buttonGO.GetComponent<Button>();
            if (button != null)
            {
                // Adicionar um listener para simular o clique
                button.onClick.AddListener(() => {
                    Debug.Log("Bot�o clicado dinamicamente!");
                    
                });

                
                button.onClick.Invoke();
            }
        }
        else
        {
            Debug.LogError("Bot�o n�o encontrado!");
        }
    }
}
