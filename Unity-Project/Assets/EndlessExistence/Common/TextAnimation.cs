
using TMPro;
using UnityEngine;

namespace EndlessExistence.Common
{
    public static class TextAnimation
    {
        // Move up and fade out the TextMeshPro text simultaneously
        public static void MoveAndFadeText(TextMeshProUGUI textMeshPro,Vector3 initPos, Vector3 targetPosition, float moveDuration, float fadeDuration)
        {
            if (textMeshPro == null)
            {
                Debug.LogError("TextMeshPro reference is null. Please provide a valid TextMeshPro component.");
                return;
            }

            // Set the initial position
            Vector3 initialPosition = initPos;

            
        }
        
        // Instantly move the TextMeshPro text
        private static void InstantMoveText(TextMeshProUGUI textMeshPro, Vector3 targetPosition)
        {
            textMeshPro.rectTransform.anchoredPosition = targetPosition;
            textMeshPro.gameObject.SetActive(false);
            
            //Debug.Log("TextMeshPro instantly moved to position: " + targetPosition);
        }
    }
}
