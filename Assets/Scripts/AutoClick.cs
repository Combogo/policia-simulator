using UnityEngine;
using UnityEngine.UI;

public class AutoClick : MonoBehaviour
{
    void Start()
    {
        // Encontrar o botão pelo nome
        GameObject buttonGO = GameObject.Find("[15] Option Node.");

        if (buttonGO != null)
        {
            Button button = buttonGO.GetComponent<Button>();
            if (button != null)
            {
                // Adicionar um listener para simular o clique
                button.onClick.AddListener(() => {
                    Debug.Log("Botão clicado dinamicamente!");
                    
                });

                
                button.onClick.Invoke();
            }
        }
        else
        {
            Debug.LogError("Botão não encontrado!");
        }
    }
}
